using NAControl.Domain.Models;
using System;
using System.Collections.Generic;

namespace NAControl.Domain.Contracts.Repositories
{
    public interface IGroupRepository: IDisposable
    {
        Group Get(string name);
        Group Get(int id);
        List<Group> Get(int skip, int take);
        void Create(Group Group);
        void Update(Group Group);
        void Delete(Group Group);
    }
}
