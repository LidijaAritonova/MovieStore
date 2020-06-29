using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStore.Data.Entities;

namespace MovieStore.Services.Service.Interfaces
{
    public interface IMovieService
    {
        void AddMovie(Movie movie);
        void EditMovie(Movie movie);
        void DeleteMovie(int movieID);

        Movie GetMovieById(int id);

        IEnumerable<Movie> GetAllMovies();
        IQueryable<Movie> GetAllMoviesQueryable();

        IEnumerable<Genre> GetGenres();
    }
}
