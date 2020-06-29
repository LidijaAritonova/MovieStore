using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStore.Data.Entities;

namespace MovieStore.Services.Service.Interfaces
{
    public interface IShoppingCartService
    {
        void Add(ShoppingCart shoppingCart);
        void Delete(int id);

        ShoppingCart GetShoppingCartById(int id);

        IEnumerable<ShoppingCart> GetAllItemsInCart();
        IEnumerable<ShoppingCart> GetAllItemsInCartByUserId(string userId);
    }
}
