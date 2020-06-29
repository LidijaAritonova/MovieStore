using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStore.Data;
using MovieStore.Data.Entities;
using MovieStore.Repositories.Repository.Interfaces;

namespace MovieStore.Repositories
{
    public class ProducerRepository : IProducerRepository
    {
        private readonly DataContext _context;

        public ProducerRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Producer producer)
        {
            _context.Producers.Add(producer);
            _context.SaveChanges();
        }

        public void Delete(Producer producer)
        {
            _context.Producers.Remove(producer);
            _context.SaveChanges();
        }

        public void Edit(Producer producer)
        {
            _context.Producers.Update(producer);
            _context.SaveChanges();
        }

        public Producer GetProducerById(int id)
        {
            var result = _context.Producers.FirstOrDefault(x => x.Id == id);
            return result;
        }

        public IEnumerable<Producer> GetProducers()
        {
            var result = _context.Producers.AsEnumerable();
            return result;
        }
    }
}
