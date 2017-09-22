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
            return _repository.GetById(id);
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

        public void Register(string name)
        {
            var hasGroup = _repository.Get(name);
            if (hasGroup != null)
                throw new Exception(Errors.DuplicateEmail);

            var group = new Group(name);

            _repository.Add(group);
        }

        public void Add(Group obj)
        {
            _repository.Add(obj);
        }

        public IEnumerable<Group> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Group obj)
        {
            _repository.Update(obj);
        }

        public void Remove(Group obj)
        {
            _repository.Remove(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

    }
}
