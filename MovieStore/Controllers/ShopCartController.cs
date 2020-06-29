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
    public class ShopCartController : Controller
    {
        private readonly IShoppingCartService _shoppingCartService;
        private readonly IWishlistService _wishlistService;
        private readonly IMovieService _movieService;
        private readonly IDirectorService _directorService;
        private readonly IPublisherService _publisherService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ShopCartController(IShoppingCartService shoppingCartService, IWishlistService wishlistService, IMovieService movieService, IDirectorService directorService, IPublisherService publisherService, IHttpContextAccessor httpContextAccessor)
        {
            _shoppingCartService = shoppingCartService;
            _wishlistService = wishlistService;
            _movieService = movieService;
            _directorService = directorService;
            _publisherService = publisherService;
            _httpContextAccessor = httpContextAccessor;
        }


        // GET: ShopCart
        public ActionResult Index()
        {
            List<Movie> AllMovieListFromCartByLoggedInUser = new List<Movie>();
            var TotalPriceCount = 0.0;
            var NotificationCounter = 0;


            TotalPriceCount = Math.Round(AllMovieListFromCartByLoggedInUser.Sum(x => x.PriceForRent), 2);
            NotificationCounter = _shoppingCartService.GetAllItemsInCart().Count();

            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            var itemsInCart = _shoppingCartService.GetAllItemsInCartByUserId(userId);


            foreach (var item in itemsInCart)
            {
                var movie = _movieService.GetMovieById(item.MovieId);
                if (movie != null)
                {
                    AllMovieListFromCartByLoggedInUser.Add(movie);
                }
            }
            var shopCartViewModel = new ShopCartViewMode()
            {
                TotalPrice = TotalPriceCount,
                AllMoviesAddedToCartByLoggedInUser = AllMovieListFromCartByLoggedInUser,
                AddToCartTotalCounter = NotificationCounter
            };

            ViewData["Counter"] = NotificationCounter;

            return View(shopCartViewModel); ;
        }

        public JsonResult AddToCart(int id)
        {
            // get book
            var getMovieById = _movieService.GetMovieById(id);
            // get logged in user id
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            // get other data ids
            var movieId = getMovieById.Id;
            var directorId = getMovieById.DirectorID;
            var producerId = getMovieById.ProducerID;
            var publisherId = getMovieById.PublisherID;
            var genreId = getMovieById.GenreID;

            // init shopping cart obj
            var shoppingCart = new ShoppingCart
            {
                UserId = userId,
               MovieId = movieId,
                Price = getMovieById.PriceForRent,
                DateAdded = DateTime.Now
            };

            // add to shopping cart
            _shoppingCartService.Add(shoppingCart);

            return new JsonResult(new { data = shoppingCart });
        }


        //// POST: ShopCart/Delete/5
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
    }
}