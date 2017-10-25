using NAControl.Business.DTOs;
using NAControl.Common.Resources;
using NAControl.Domain.Contracts.Repositories;
using NAControl.Domain.Contracts.Services;
using NAControl.Domain.Models;
using System;
using System.Collections.Generic;

namespace NAControl.Business.Services
{
    public class GroupService : IGroupService
    {
        private IGroupRepository _repository;

        public GroupService(IGroupRepository repository)
        {
            _repository = repository;
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

        public List<Group> GetByPartialName(string name)
        {
            return _repository.GetPartialName(name);
        }

        public List<Group> GetByRange(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        public IEnumerable<Group> GetAll()
        {
            return _repository.GetAll();
        }

        public void Register(object obj)
        {
            var group = ConvertDTO(obj);
            var hasGroup = _repository.Get(group.Name);
            if (hasGroup != null)
                throw new Exception(Errors.DuplicateEmail);

            _repository.Add(group);
        }

        public void Add(Group obj)
        {
            _repository.Add(obj);
        }

        public void Alter(object obj)
        {
            var group = ConvertDTO(obj);
            Update(group);
        }

        public void Update(Group obj)
        {
            _repository.Update(obj);
        }

        public void ChangeGroup(string name)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            Group group = _repository.GetById(id);
            Remove(group);
        }

        public void Remove(Group obj)
        {
            _repository.Remove(obj);
        }

        public Group ConvertDTO(object obj)
        {
            GroupDTO model = (GroupDTO)obj;
            Address address = new Address(model.Address.AddId ,model.Address.Addresses, model.Address.Complement, model.Address.City, model.Address.Latitude, model.Address.Longitude);

            List<Meeting> listMeeting = new List<Meeting>();

            if (model.MeetingList != null)
            {
                foreach (var item in model.MeetingList)
                {
                    Meeting meeting = new Meeting(item.MeeId, item.Private, item.Day, item.Start, item.End, null);
                    listMeeting.Add(meeting);
                }
            }

            var group = new Group(model.GroId,model.Name, address, listMeeting);
            return group;
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

    }
}
