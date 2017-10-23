using NAControl.Domain.Contracts.Repositories;
using NAControl.Domain.Models;
using NAControl.Infraestructure.Data;
using System.Collections.Generic;
using System.Linq;

namespace NAControl.Infraestructure.Repositories
{
    public class MeetingRepository : RepositoryBase<Meeting>, IMeetingRepository
    {
        private AppDataContext _context;

        public MeetingRepository(AppDataContext _context)
            : base(_context)
        {
            this._context = _context;
        }

        public List<Meeting> Get(int skip, int take)
        {
            return _context.Meetings.Include("Group.Address").OrderBy(x => x.Group.Name).Skip(skip).Take(take).ToList();
        }
    }
}
