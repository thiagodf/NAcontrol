using NAControl.Domain.Contracts.Repositories;
using NAControl.Domain.Contracts.Services;
using NAControl.Domain.Models;
using System.Collections.Generic;

namespace NAControl.Business.Services
{
    public class MeetingService : IMeetingService
    {
        IMeetingRepository _repository;

        public MeetingService(IMeetingRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Meeting> GetAll()
        {
            return _repository.GetAll();
        }

        public List<Meeting> GetByRange(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        public Meeting GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Add(Meeting obj)
        {
            _repository.Add(obj);
        }

        public void Update(Meeting obj)
        {
            _repository.Update(obj);
        }

        public void Remove(Meeting obj)
        {
            _repository.Remove(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

    }
}
