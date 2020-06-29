using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MovieStore.Data.Entities;
using MovieStore.Logger;
using MovieStore.Repositories.Repository.Interfaces;
using MovieStore.Services.Service.Interfaces;

namespace MovieStore.Services
{
    public class MovieService:IMovieService
    {
        private readonly IMovieReprository _movieRepository;
        private readonly ILogger<MovieService> _logger;

        public MovieService(IMovieReprository movieRepository, ILogger<MovieService> logger )
        {
            _movieRepository = movieRepository;
            _logger = logger;
        }

        public void AddMovie(Movie movie)
        {
            try
            {
                _movieRepository.AddMovie(movie);
                _logger.LogInformation(LoggerMessageDisplay.MovieAdd);
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggerMessageDisplay.MovieNotCreatedModelStateInvalid, ex);
            }
        }

        public void DeleteMovie(int movieID)
        {
            _movieRepository.DeleteMovie(movieID);
            _logger.LogInformation(LoggerMessageDisplay.MovieDeleted);
        }

        public void EditMovie(Movie movie)
        {
            try { 
            _movieRepository.EditMovie(movie);
                _logger.LogInformation(LoggerMessageDisplay.MovieEdited);
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggerMessageDisplay.MovieEditErrorModelStateInvalid, ex);
            }
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            var result = _movieRepository.GetAllMovies();
            return result;
        }

        public IQueryable<Movie> GetAllMoviesQueryable()
        {
            var result = _movieRepository.GetAllMoviesQueryable();
            return result;
        }

        public IEnumerable<Genre> GetGenres()
        {
            var result = _movieRepository.GetGenres();
            return result;
        }

        public Movie GetMovieById(int id)
        {
            var result = _movieRepository.GetMovieById(id);
            return result;
        }
    }
}
