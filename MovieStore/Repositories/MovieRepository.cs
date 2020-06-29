using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MovieStore.Data;
using MovieStore.Data.Entities;
using MovieStore.Logger;
using MovieStore.Repositories.Repository.Interfaces;

namespace MovieStore.Repositories
{
    public class MovieRepository : IMovieReprository
    {
        private readonly DataContext _context;
        private readonly ILogger<MovieRepository> _logger;

        public MovieRepository(DataContext context, ILogger<MovieRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void AddMovie(Movie movie)
        {
            try
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
                _logger.LogInformation(LoggerMessageDisplay.MovieAdd);
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggerMessageDisplay.MovieNotCreatedModelStateInvalid, ex);
            }
            
           
        }

        public void DeleteMovie(int movieID)
        {
            Movie movie = GetMovieById(movieID);
            _context.Movies.Remove(movie);
            _context.SaveChanges();
            _logger.LogInformation(LoggerMessageDisplay.MovieDeleted);
        }

        public void EditMovie(Movie movie)
        {
            try
            {
                _context.Movies.Update(movie);
                _context.SaveChanges();
                _logger.LogInformation(LoggerMessageDisplay.MovieEdited);
            }
            catch(Exception ex)
            {
                _logger.LogError(LoggerMessageDisplay.MovieEditErrorModelStateInvalid, ex);
            }
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            var result = _context.Movies.AsEnumerable();
            return result;
        }

        public IQueryable<Movie> GetAllMoviesQueryable()
        {
            var result = _context.Movies.AsQueryable();
            return result;
        }

        public IEnumerable<Genre> GetGenres()
        {
            var result = _context.Genres.AsEnumerable();
            return result;
        }

        public Movie GetMovieById(int id)
        {
            var result = _context.Movies.FirstOrDefault(x => x.Id == id);
            return result;
        }
    }
}
