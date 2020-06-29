using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoreLinq;
using MovieStore.Data;
using MovieStore.Data.Entities;
using MovieStore.Repositories.Repository.Interfaces;

namespace MovieStore.Repositories
{
    public class WishlistRepository : IWishlistRepository
    {
        private readonly DataContext _context;

        public WishlistRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Wishlist wishlist)
        {
            _context.Wishlists.Add(wishlist);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var wishlist = GetWishlistById(Id);
            _context.Wishlists.Remove(wishlist);
            _context.SaveChanges();
        }

        
        public void Edit(Wishlist wishlist)
        {
            _context.Wishlists.Update(wishlist);
            _context.SaveChanges();
        }

        public IEnumerable<Wishlist> GetAllWishlistByUserId(string userId)
        {
            var result = _context.Wishlists.AsEnumerable().Where(x => x.UserId == userId).DistinctBy(x => x.MovieId);
            return result;
        }

        public IEnumerable<Wishlist> GetAllWishlists()
        {
            var result = _context.Wishlists.AsEnumerable();
            return result;
        }

        public Wishlist GetWishlistById(int id)
        {
            var result = _context.Wishlists.FirstOrDefault(x => x.Id == id);
            return result;
        }

        public Wishlist GetWishlistByMovieId(int id)
        {
            var result = _context.Wishlists.FirstOrDefault(x => x.Id == id);
            return result;
        }

        public void DeleteByMovieId(int Id)
        {
            var wishlist = GetWishlistByMovieId(Id);
            _context.Wishlists.Remove(wishlist);
            _context.SaveChanges();
        }
    }
}
