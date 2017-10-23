using NAControl.Domain.Models;
using System;
using System.Collections.Generic;

namespace NAControl.Domain.Contracts.Services
{
    public interface IGroupService: IServiceBase<Group>
    {
        Group GetById(int id);
        Group GetByName(string name);
        List<Group> GetByRange(int skip, int take);
        void Register(object group);
        void Alter(object group);
        void Delete(int id);
        Group ConvertDTO(object group);
    }
}
