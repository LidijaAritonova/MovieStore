using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStore.Data.Entities;

namespace MovieStore.Services.Service.Interfaces
{
   public interface IWishlistService
    {
        void Add(Wishlist wishlist);
        void Edit(Wishlist wishlist);
        void Delete(int id);

        void DeleteByMovieId(int movieID);

        Wishlist GetWishlistById(int id);
        Wishlist GetWishlistByMovieId(int movieID);
        IEnumerable<Wishlist> GetAllWishlists();
        IEnumerable<Wishlist> GetAllWishlistByUserId(string userId);

       
    }
}
