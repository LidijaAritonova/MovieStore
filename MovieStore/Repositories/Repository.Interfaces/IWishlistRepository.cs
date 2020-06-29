using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStore.Data.Entities;

namespace MovieStore.Repositories.Repository.Interfaces
{
    public interface IWishlistRepository
    {
        void Add(Wishlist wishlist);
        void Edit(Wishlist wishlist);
        void Delete(int id);
       
        IEnumerable<Wishlist> GetAllWishlists();
        Wishlist GetWishlistById(int id);

        void DeleteByMovieId(int movieID);

        Wishlist GetWishlistByMovieId(int movieID);

        IEnumerable<Wishlist> GetAllWishlistByUserId(string userId);

    }
}
