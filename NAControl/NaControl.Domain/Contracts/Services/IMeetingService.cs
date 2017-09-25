using NAControl.Domain.Models;
using System.Collections.Generic;

namespace NAControl.Domain.Contracts.Services
{
    public interface IMeetingService: IServiceBase<Meeting>
    {
        void Register(string name);
        //Group GetById(int id);
        //void ChangeGroup(string name);
        List<Meeting> GetByRange(int skip, int take);
    }
}
