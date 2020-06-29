using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStore.Data.Entities;

namespace MovieStore.Repositories.Repository.Interfaces
{
   public interface IMovieReprository
    {
        void AddMovie(Movie movie);
        void EditMovie(Movie movie);
        void DeleteMovie(int movieID);

        Movie GetMovieById(int id);

        IEnumerable<Movie> GetAllMovies();
        IQueryable<Movie> GetAllMoviesQueryable();

        IEnumerable<Genre> GetGenres();


        //IEnumerable<Book> GetAllBooksByUser(User user);
        //IEnumerable<Book> GetAllBooksByUserId(int userId);
        //IEnumerable<Book> GetAllBooksByDateDescending();
        //IEnumerable<Book> GetAllBooksByDateAccending();
        //IEnumerable<Book> GetAllBooksFromToDateByUserId(int userId, DateTime from, DateTime to);
        //IEnumerable<Book> GetAllBooksByPriceAccending();
        //IEnumerable<Book> GetAllBooksByPriceDescending();
        //IEnumerable<Book> GetAllBooksByGeoLocationCountry(string country);
        //IEnumerable<Book> GetAllBooksByPublisher(Publisher publisher);
        //IEnumerable<Book> GetAllBooksForWishlist();
        //IEnumerable<Book> GetTopPopularBooks();
        //IEnumerable<Book> GetTopPopularBooksByBestSellingAuthor(int authorId);
    }
}
