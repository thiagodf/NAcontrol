using NAControl.Domain.Models;
using System;
using System.Collections.Generic;

namespace NAControl.Domain.Contracts.Services
{
    public interface IGroupService: IServiceBase<Group>
    {
        Group GetByName(string name);
        void Register(string name);
        //Group GetById(int id);
        //void ChangeGroup(string name);
        List<Group> GetByRange(int skip, int take);
    }
}
