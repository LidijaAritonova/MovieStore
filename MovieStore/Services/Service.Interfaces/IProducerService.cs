using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStore.Data.Entities;

namespace MovieStore.Services.Service.Interfaces
{
    public interface IProducerService
    {
        void Add(Producer producer);
        void Edit(Producer producer);
        void Delete(Producer producer);

        IEnumerable<Producer> GetProducers();
        Producer GetProducerById(int id);
    }
}
