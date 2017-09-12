using NAControl.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAControl.Domain.Models;
using NAControl.Common.Resources;
using NAControl.Domain.Contracts.Repositories;

namespace NAControl.Business.Services
{
    public class GroupService : IGroupService
    {

        private IGroupRepository _repository;

        public GroupService(IGroupRepository repository)
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
            var hasGroup = _repository.Get(name);
            if (hasGroup == null)
                throw new Exception(Errors.UserNotFound);

            return hasGroup;
        }

        public List<Group> GetByRange(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        //public void Dispose()
        //{
        //    _repository.Dispose();
        //}

        public void Register(string name)
        {
            var hasGroup = _repository.Get(name);
            if (hasGroup != null)
                throw new Exception(Errors.DuplicateEmail);

            var User = new Group(name);

            _repository.Add(User);
        }

        public void Add(Group obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Group> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Group obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(Group obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
