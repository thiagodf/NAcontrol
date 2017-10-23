using NAControl.Domain.Models;
using System;
using System.Collections.Generic;

namespace NAControl.Domain.Contracts.Repositories
{
    public interface IGroupRepository: IRepositoryBase<Group>
    {
        Group Get(string name);
        Group GetById(int id);
        List<Group> Get(int skip, int take);
        //void Create(Group Group);
        //void Update(Group Group);
        //void Delete(Group Group);
    }
}
