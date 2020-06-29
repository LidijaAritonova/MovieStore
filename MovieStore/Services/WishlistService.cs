using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MovieStore.Data.Entities;
using MovieStore.Repositories.Repository.Interfaces;
using MovieStore.Services.Service.Interfaces;

namespace MovieStore.Services
{
    public class WishlistService : IWishlistService
    {
        private readonly IMovieReprository _movieRepository;
        private readonly IWishlistRepository _wishlistRepository;
        private UserManager<IdentityUser> _userManager;

        public WishlistService(IMovieReprository movieRepository, IWishlistRepository wishlistRepository, UserManager<IdentityUser> userManager)
        {
            _movieRepository = movieRepository;
            _wishlistRepository = wishlistRepository;
            _userManager = userManager;
        }

        public void Add(Wishlist wishlist)
        {
            _wishlistRepository.Add(wishlist);
        }

        public void Delete(int id)
        {
            _wishlistRepository.Delete(id);
        }

        public void Edit(Wishlist wishlist)
        {
            _wishlistRepository.Edit(wishlist);
        }

        public IEnumerable<Wishlist> GetAllWishlistByUserId(string userId)
        {
            var result = _wishlistRepository.GetAllWishlistByUserId(userId);
            return result;
        }

        public IEnumerable<Wishlist> GetAllWishlists()
        {
            var result = _wishlistRepository.GetAllWishlists();
            return result;
        }

        public Wishlist GetWishlistById(int id)
        {
            var result = _wishlistRepository.GetWishlistById(id);
            return result;
        }

        public Wishlist GetWishlistByMovieId(int movieID)
        {
            var result = _wishlistRepository.GetWishlistById(movieID);
            return result;
        }
        public void DeleteByMovieId(int bookID)
        {
            _wishlistRepository.DeleteByMovieId(bookID);
        }
    }
}
