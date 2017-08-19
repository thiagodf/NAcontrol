using NAControl.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAControl.Domain.Models;

namespace NAControl.Business.Services
{
    public class GroupService : IGroupService
    {
        private IGroupService _repository;

        public GroupService(IGroupService repository)
        {
            _repository = repository;
        }

        public void ChangeGroup(string name)
        {
            throw new NotImplementedException();
        }

        public Group GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Group GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Group> GetByRange(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
