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
    public class ShoppingCartService: IShoppingCartService
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IMovieReprository _movieReprository;
        private readonly IWishlistRepository _wishlistRepository;
        private UserManager<IdentityUser> _userManager;

        public ShoppingCartService(IShoppingCartRepository shoppingCartRepository, IMovieReprository movieReprository, IWishlistRepository wishlistRepository, UserManager<IdentityUser> userManager)
        {
            _shoppingCartRepository = shoppingCartRepository;
            _movieReprository = movieReprository;
            _wishlistRepository = wishlistRepository;
            _userManager = userManager;
        }

        public void Add(ShoppingCart shoppingCart)
        {
            _shoppingCartRepository.Add(shoppingCart);
        }

        public void Delete(int id)
        {
            _shoppingCartRepository.Delete(id);
        }

        public IEnumerable<ShoppingCart> GetAllItemsInCart()
        {
            var result = _shoppingCartRepository.GetAllItemsInCart();
            return result;
        }

        public IEnumerable<ShoppingCart> GetAllItemsInCartByUserId(string userId)
        {
            var result = _shoppingCartRepository.GetAllItemsInCartByUserId(userId);
            return result;
        }

        public ShoppingCart GetShoppingCartById(int id)
        {
            var result = _shoppingCartRepository.GetShoppingCartById(id);
            return result;
        }
    }
}
