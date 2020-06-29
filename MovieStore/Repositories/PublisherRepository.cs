using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStore.Data;
using MovieStore.Data.Entities;
using MovieStore.Repositories.Repository.Interfaces;

namespace MovieStore.Repositories
{
    public class PublisherRepository : IPublisherRepository
    {
        private readonly DataContext _context;

        public PublisherRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Publisher publisher)
        {
            _context.Publishers.Add(publisher);
            _context.SaveChanges();
        }

        public void Delete(Publisher publisher)
        {
            _context.Publishers.Remove(publisher);
            _context.SaveChanges();
        }

        public void Edit(Publisher publisher)
        {
            _context.Publishers.Update(publisher);
            _context.SaveChanges();
        }

        public Publisher GetPublisherById(int id)
        {
            var result= _context.Publishers.FirstOrDefault(x => x.Id == id);
            return result;
        }

        public IEnumerable<Publisher> GetPublishers()
        {
            var result = _context.Publishers.AsEnumerable();
            return result;
        }
    }
}
