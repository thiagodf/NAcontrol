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
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Meeting> GetAll()
        {
            throw new NotImplementedException();
        }

        public Meeting GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Meeting obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Meeting obj)
        {
            throw new NotImplementedException();
        }
    }
}
