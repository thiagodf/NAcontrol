using NAControl.Domain.Models;
using System.Collections.Generic;

namespace NAControl.Domain.Contracts.Services
{
    public interface IMeetingService: IServiceBase<Meeting>
    {
        List<Meeting> GetByRange(int skip, int take);
    }
}
