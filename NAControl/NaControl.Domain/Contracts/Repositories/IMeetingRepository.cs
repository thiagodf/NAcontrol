using NAControl.Domain.Models;
using System.Collections.Generic;

namespace NAControl.Domain.Contracts.Repositories
{
    public interface IMeetingRepository: IRepositoryBase<Meeting>
    {
        List<Meeting> Get(int skip, int take);
    }
}
