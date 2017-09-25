using NAControl.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAControl.Domain.Models;
using NAControl.Domain.Contracts.Repositories;

namespace NAControl.Business.Services
{
    public class MeetingService : IMeetingService
    {
        IMeetingRepository _repository;

        public MeetingService(IMeetingRepository repository)
        {
            _repository = repository;
        }

        public void Add(Meeting obj)
        {
            _repository.Add(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
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

        public void Remove(Meeting obj)
        {
            _repository.Remove(obj);
        }

        public void Update(Meeting obj)
        {
            _repository.Update(obj);
        }

        public void Register(string name)
        {
            throw new NotImplementedException();
        }
    }
}
