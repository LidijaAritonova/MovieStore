using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using MovieStore.Data.Entities;
using MovieStore.Logger;
using MovieStore.Models;
using MovieStore.Services.Service.Interfaces;

namespace MovieStore.Controllers
{
    [Authorize(Roles = "admin, editor")]
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly IDirectorService _directorService;
        private readonly IProducerService _producerService;
        private readonly IPublisherService _publisherService;
        private readonly ILogger<MovieController> _logger;



        public MovieController(IMovieService movieService,
                               IDirectorService directorService, 
                               IProducerService producerService, 
                               IPublisherService publisherService,
                                ILogger<MovieController> logger) 
        {
            _movieService = movieService;
            _directorService = directorService;
            _producerService = producerService;
            _publisherService = publisherService;
            _logger = logger;
        }


        // GET: Movie
        public IActionResult Index()
        {
            var movieList = _movieService.GetAllMovies();

            if (movieList != null)
            {
                _logger.LogInformation(LoggerMessageDisplay.MovieListed);
            }
            else
            {
                _logger.LogInformation(LoggerMessageDisplay.NoMovie);
            }


            return View(movieList);
        }

        [HttpGet]
        public JsonResult FillMovieDataTable()
        {
            var movielist = _movieService.GetAllMovies();
            return Json(new { data = movielist });
        }

        // GET: Movie/Details/5
        public IActionResult Details(int id)

        {
            var movie = _movieService.GetMovieById(id);
            _logger.LogInformation(LoggerMessageDisplay.MovieDisplayDetails);

            if (movie == null)
            {
                _logger.LogWarning(LoggerMessageDisplay.NoMovieFound);
                return NotFound();
            }
            return View(movie);
        }


        // [HttpGet]
        // public JsonResult DetailMovieDataTable(int id)
        // {
        //   var book = _movieService.GetMovieById(id);
        //    return Json(new { detailsData = book });
        //  }


        // GET: Movie/Create
       [Authorize(Roles = "admin")]
        public IActionResult Create()
        {
            var Genres = _movieService.GetGenres();
            var Directors = _directorService.GetDirectors();
            var Producers = _producerService.GetProducers();
            var Publishers = _publisherService.GetPublishers();

           MovieViewModel movieViewModel = new MovieViewModel
            {
               Genres = GetSelectListItemsGenres(Genres),
               Directors = GetSelectListItemsDirectors(Directors),
               Producers = GetSelectListProducers(Producers),
               Publishers = GetSelectListPublishers(Publishers)
            };

            return View(movieViewModel);
        }

        private IEnumerable<SelectListItem> GetSelectListItemsGenres(IEnumerable<Genre> genres)
        {
            var selectList = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Value = "0",
                    Text = "Select genre..."
                }
            };
            foreach (var element in genres)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element.Id.ToString(),
                    Text = element.Name
                });
            }
            return selectList;
        }

        private IEnumerable<SelectListItem> GetSelectListItemsDirectors(IEnumerable<Director> directors)
        {
            var selectList = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Value = "0",
                    Text = "Select director..."
                }
            };
            foreach (var element in directors)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element.Id.ToString(),
                    Text = element.Name
                });
            }
            return selectList;
        }

        private IEnumerable<SelectListItem> GetSelectListProducers(IEnumerable<Producer> producers)
        {
            var selectList = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Value = "0",
                    Text = "Select producer..."
                }
            };
            foreach (var element in producers)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element.Id.ToString(),
                    Text = element.Name
                });
            }
            return selectList;
        }


        private IEnumerable<SelectListItem> GetSelectListPublishers(IEnumerable<Publisher> publishers)
        {
            var selectList = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Value = "0",
                    Text = "Select publisher..."
                }
            };
            foreach (var element in publishers)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element.Id.ToString(),
                    Text = element.Name
                });
            }
            return selectList;
        }





        // POST: Movie/Create
       [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MovieViewModel movieViewModel)
        {
            var movie = new Movie();

            if (ModelState.IsValid)
            {
                movie.Budget = movieViewModel.Budget;
                movie.Cast = movieViewModel.Cast;
                movie.Director = movieViewModel.Director;
                movie.DirectorID = movieViewModel.DirectorID;
                movie.DirectorName = movieViewModel.DirectorName;
                movie.GenreID = movieViewModel.GenreID;
                movie.GenreName = movieViewModel.GenreName;
                movie.PhotoURL = movieViewModel.PhotoURL;
                movie.PriceForBuy = movieViewModel.PriceForBuy;
                movie.PriceForRent = movieViewModel.PriceForRent;
                movie.Producer = movieViewModel.Producer;
                movie.ProducerID = movieViewModel.ProducerID;
                movie.ProducerName = movieViewModel.ProducerName;
                movie.Publisher = movieViewModel.Publisher;
                movie.PublisherID = movieViewModel.PublisherID;
                movie.PublisherName = movieViewModel.PublisherName;
                movie.Released = movieViewModel.Released;
                movie.Runtime = movieViewModel.Runtime;
                movie.Synopsis = movieViewModel.Synopsis;
                movie.Title = movieViewModel.Title;
                movie.Traller = movieViewModel.Traller;
    

                _movieService.AddMovie(movie);
                _logger.LogInformation(LoggerMessageDisplay.MovieAdd);
                return RedirectToAction(nameof(Index));
            }

            _logger.LogError(LoggerMessageDisplay.MovieNotCreatedModelStateInvalid);
                return View(movie);
        }


        [HttpPost]
        public IActionResult UploadPhoto()
        {
            try
            {
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("wwwroot", "images");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = fileName;

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    _logger.LogInformation(LoggerMessageDisplay.PhotoUploaded);
                    return Ok(new { dbPath });
                }
                else
                {
                    _logger.LogError(LoggerMessageDisplay.PhotoUploadedError);
                    return BadRequest();
                }
            }
            catch (System.Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }


        // GET: Movie/Edit/5
        public IActionResult Edit(int id)
        {
            var movie = _movieService.GetMovieById(id);

            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: Movie/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Movie movie)
        {
            if (id != movie.Id)
            {
                _logger.LogWarning(LoggerMessageDisplay.MovieEditNotFound);
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _movieService.EditMovie(movie);
                    _logger.LogInformation(LoggerMessageDisplay.MovieEdited);
                }
                catch (Exception ex)
                {
                    _logger.LogInformation(LoggerMessageDisplay.MovieEditErrorModelStateInvalid + " ---> " + ex);
                    throw;
                }
                _logger.LogError(LoggerMessageDisplay.MovieEditErrorModelStateInvalid);
                return RedirectToAction(nameof(Index));
            }
    
            return View(movie);
        }

        // GET: Movie/Delete/5
        [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {
            var movie = _movieService.GetMovieById(id);
            if (movie == null)
            {
                return NotFound();
            }
          
            return View(movie);
        }

        // POST: Movie/Delete/5
       [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _movieService.DeleteMovie(id);
                _logger.LogInformation(LoggerMessageDisplay.MovieDeleted);
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggerMessageDisplay.MovieDeletedError + " ---> " + ex);
                throw;
            }

            _logger.LogError(LoggerMessageDisplay.MovieDeletedError);
            return RedirectToAction(nameof(Index));
        }
    }
}