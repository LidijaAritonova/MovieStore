using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieStore.Data.Entities;
using MovieStore.Logger;
using MovieStore.Models;
using MovieStore.Services.Service.Interfaces;

namespace MovieStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMovieService _movieService;
        private readonly IDirectorService _directorService;
        private readonly IPublisherService _publisherService;
        private readonly IWishlistService _wishlistService;
        private readonly IShoppingCartService _shoppingCartService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HomeController(ILogger<HomeController> logger, IMovieService movieService, IDirectorService directorService, IPublisherService publisherService, IWishlistService wishlistService, IShoppingCartService shoppingCartService, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _movieService = movieService;
            _directorService = directorService;
            _publisherService = publisherService;
            _wishlistService = wishlistService;
            _shoppingCartService = shoppingCartService;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
           
            var GetAllMovies = _movieService.GetAllMovies();
            var notificationCounters = _shoppingCartService.GetAllItemsInCart().Count();
            

            var movieViewModel = new MovieViewModel
            {
               
                AllMovies = GetAllMovies,
                AddToCartTotalCounter = notificationCounters
            };

            ViewData["Counter"] = notificationCounters;

            return View(movieViewModel);
        }

        [HttpPost]
        public IActionResult RefreshPartialViewNotification()
        {
            var notificationCounters = _shoppingCartService.GetAllItemsInCart().Count();
            ViewData["Counter"] = notificationCounters;
            return PartialView("Notification");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public int AddToCartNotificationsCounterTest()
        {
            var notificationCounters = _shoppingCartService.GetAllItemsInCart().Count();
            return notificationCounters;
        }

        [HttpPost]
        public JsonResult AddToWishlist(int id)
        {
    
            var getMovieById = _movieService.GetMovieById(id);

            var CheckIfExistsInWishlist = _wishlistService.GetWishlistByMovieId(id);

            if (CheckIfExistsInWishlist == null)
            {
                // get logged in user id
                var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                // get other data ids
                var movieId = getMovieById.Id;
                var directorId = getMovieById.DirectorID;
                var producerId = getMovieById.ProducerID;
                var publisherId = getMovieById.PublisherID;
                var genreId = getMovieById.GenreID;
              

                // init wishlist obj
                var wishlist = new Wishlist
                {
                    UserId = userId,
                    MovieId = movieId,
                    DirectorId= directorId,
                    ProducerId= producerId,
                    PublisherId = publisherId,
                    GenreId= genreId,
                    DateAdded = DateTime.Now
                };

                // add to wishlist
                _wishlistService.Add(wishlist);

                return new JsonResult(new { data = wishlist });
            }
            else
            {
                return new JsonResult(new { data = "" });
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Details(int id)
        {
            var movie = _movieService.GetMovieById(id);
            return View(movie);
        }

        // // GET: Home/Details/5
        // public IActionResult Details(int id)

        // {
        //     var movie = _movieService.GetMovieById(id);
        //     //_logger.LogInformation(LoggerMessageDisplay.MovieDisplayDetails);

        //     //if (movie == null)
        //  //  {
        //     //    _logger.LogWarning(LoggerMessageDisplay.NoMovieFound);
        //    //   return NotFound();
        ////   }
        //     return View(movie);
        // }
    }

}
