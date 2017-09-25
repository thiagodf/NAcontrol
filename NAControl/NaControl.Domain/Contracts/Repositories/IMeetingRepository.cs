using NAControl.Domain.Models;
using System;
using System.Collections.Generic;

namespace NAControl.Domain.Contracts.Repositories
{
    public interface IMeetingRepository: IRepositoryBase<Meeting>
    {
        //Group Get(int id);
        List<Meeting> Get(int skip, int take);
        //void Create(Group Group);
        //void Update(Group Group);
        //void Delete(Group Group);
    }
}
