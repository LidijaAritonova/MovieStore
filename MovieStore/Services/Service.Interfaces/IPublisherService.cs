using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStore.Data.Entities;

namespace MovieStore.Services.Service.Interfaces
{
    public interface IPublisherService
    {
        void Add(Publisher publisher);
        void Edit(Publisher publisher);
        void Delete(Publisher publisher);

        IEnumerable<Publisher> GetPublishers();
        Publisher GetPublisherById(int id);
    }
}
