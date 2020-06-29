using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStore.Data;
using MovieStore.Data.Entities;
using MovieStore.Repositories.Repository.Interfaces;

namespace MovieStore.Repositories
{
    public class DirectorRepository : IDirectorRepository
    {
        private readonly DataContext _context;

        public DirectorRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Director director)
        {
            _context.Directors.Add(director);
            _context.SaveChanges();
        }

        public void Delete(Director director)
        {
            _context.Directors.Remove(director);
            _context.SaveChanges();
        }

        public void Edit(Director director)
        {
            _context.Directors.Update(director);
            _context.SaveChanges();
        }

        public Director GetDidectorById(int id)
        {
            var result = _context.Directors.FirstOrDefault(x => x.Id == id);
            return result;
        }

        public Director GetDirectorByPopularity()
        {
            var result = _context.Directors.Where(x => x.Popularity == true).FirstOrDefault();
            return result;
        }

        public IEnumerable<Director> GetDirectors()
        {
            var result = _context.Directors.AsEnumerable();
            return result;
        }
    }
}
