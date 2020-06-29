using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStore.Data.Entities;
using MovieStore.Repositories.Repository.Interfaces;
using MovieStore.Services.Service.Interfaces;

namespace MovieStore.Services
{
    public class ProducerService : IProducerService
    {
        private readonly IProducerRepository _producerRepository;

        public ProducerService(IProducerRepository producerRepository)
        {
            _producerRepository = producerRepository;
        }

        public void Add(Producer producer)
        {
            _producerRepository.Add(producer);
        }

        public void Delete(Producer producer)
        {
            _producerRepository.Delete(producer);

        }

        public void Edit(Producer producer)
        {
            _producerRepository.Edit(producer);
        }

        public Producer GetProducerById(int id)
        {
            var result = _producerRepository.GetProducerById(id);
            return result;
        }

        public IEnumerable<Producer> GetProducers()
        {
            var result = _producerRepository.GetProducers();
            return result;
        }
    }
}
