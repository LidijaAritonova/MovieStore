using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStore.Data.Entities;

namespace MovieStore.Repositories.Repository.Interfaces
{
    public interface IDirectorRepository
    {
        void Add(Director director);
        void Edit(Director director);
        void Delete(Director director);

        IEnumerable<Director> GetDirectors();
        Director GetDidectorById(int id);
        Director GetDirectorByPopularity();
    }
}
