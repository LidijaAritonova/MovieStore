using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Data.Entities;
using MovieStore.Models;
using MovieStore.Services.Service.Interfaces;

namespace MovieStore.Controllers
{
    [Authorize(Roles = "admin, user")]

    public class WishListController : Controller
    {
        private readonly IWishlistService _wishlistService;
        private readonly IShoppingCartService _shoppingCartService;
        private readonly IMovieService _movieService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public WishListController(IWishlistService wishlistService, IShoppingCartService shoppingCartService, IMovieService movieService, IHttpContextAccessor httpContextAccessor)
        {
            _wishlistService = wishlistService;
            _shoppingCartService = shoppingCartService;
            _movieService = movieService;
            _httpContextAccessor = httpContextAccessor;
        }


        // GET: WishList
        public IActionResult Index()
        {
            List<double> GetAllPrices_temp = new List<double>();

            List<Movie> AllMovieListFromWishlistByLoggedInUser = new List<Movie>();
            var TotalPriceCount = 0.0;

           // TotalPriceCount = Math.Round(AllMovieListFromWishlistByLoggedInUser.Sum(x => x.PriceForRent), 2);

            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var wishlists = _wishlistService.GetAllWishlistByUserId(userId);

            foreach (var item in wishlists)
            {
                var movie = _movieService.GetMovieById (item.MovieId);
                if (movie != null)
                {

                    AllMovieListFromWishlistByLoggedInUser.Add(movie);
                }
            }
            var movieViewModel = new MovieViewModel();
            movieViewModel.AllMoviesFromWishlistByLoggedInUser = AllMovieListFromWishlistByLoggedInUser;
            movieViewModel.WishlistTotalPrice = TotalPriceCount;

            return View(movieViewModel);
        }

        // GET: WishList/Details/5
        public IActionResult Details(int id)
        {
            var movie = _movieService.GetMovieById(id);
            return View(movie);
        }

        //// GET: WishList/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: WishList/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: WishList/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: WishList/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: WishList/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: WishList/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        [HttpPost]
        public JsonResult Delete(int Id)
        {
            var getMovie = _movieService.GetMovieById(Id);

            _wishlistService.DeleteByMovieId(Id);

            return new JsonResult(new { data = getMovie, url = Url.Action("Index", "WishList") });
        }

        public JsonResult AddToCartFromWishlist(List<string> movieIds)
        {
            // add to temporary list
            List<string> movieIds_temp = movieIds;
           
            foreach (var movie in movieIds_temp)
            {
                var getMovie = _movieService.GetMovieById(int.Parse(movie));

                // get logged in user id
                var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                // get other data ids
                var movieId = getMovie.Id;

                // init shopping cart obj
                var shoppingCart = new ShoppingCart
                {
                    UserId = userId,
                    MovieId = movieId,
              //      Price = getMovie.PriceForRent,
                    DateAdded = DateTime.Now
                };

                // add single movie from wishlist to shopping cart
                _shoppingCartService.Add(shoppingCart);
            }

            // remove all selected items from wishlist
            foreach (var selectedItem in movieIds)
            {
                _wishlistService.DeleteByMovieId(int.Parse(selectedItem));
            }

            return new JsonResult(new { data = "" });
        }

        public IActionResult GoToCart()
        {
            return RedirectToAction("Index", "ShopCart");
        }
    }
}