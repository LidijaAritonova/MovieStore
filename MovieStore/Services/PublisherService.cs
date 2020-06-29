using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStore.Data.Entities;
using MovieStore.Repositories.Repository.Interfaces;
using MovieStore.Services.Service.Interfaces;

namespace MovieStore.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly IPublisherRepository _publisherRepository;

        public PublisherService(IPublisherRepository publisherRepository)
        {
            _publisherRepository = publisherRepository;
        }

        public void Add(Publisher publisher)
        {
            _publisherRepository.Add(publisher);
        }

        public void Delete(Publisher publisher)
        {
            _publisherRepository.Delete(publisher);
        }

        public void Edit(Publisher publisher)
        {
            _publisherRepository.Edit(publisher);
        }

        public Publisher GetPublisherById(int id)
        {
           return _publisherRepository.GetPublisherById(id);
        }

        public IEnumerable<Publisher> GetPublishers()
        {
            return _publisherRepository.GetPublishers();
        }
    }
}
