using NAControl.Domain.Contracts.Repositories;
using NAControl.Domain.Models;
using NAControl.Infraestructure.Data;
using System.Collections.Generic;
using System.Linq;

namespace NAControl.Infraestructure.Repositories
{
    public class GroupRepository : RepositoryBase<Group>, IGroupRepository
    {
        private AppDataContext _context;

        public GroupRepository(AppDataContext _context)
            : base(_context)
        {
            this._context = _context;
        }

        public Group Get(string name)
        {
            return _context.Groups.Include("Address").Include("MeetingList").Where(x => x.Name.ToLower() == name.ToLower()).FirstOrDefault();
        }

        public Group GetById(int id)
        {
            return _context.Groups.Include("Address").Include("MeetingList").Where(x => x.GroId == id).FirstOrDefault();
        }

        public List<Group> Get(int skip, int take)
        {
            return _context.Groups.Include("Address").Include("MeetingList").ToList().OrderBy(x => x.Name).Skip(skip).Take(take).ToList();
        }

        public List<Group> GetPartialName(string name)
        {
            return _context.Groups.Include("Address").Include("MeetingList").ToList().OrderBy(x => x.Name).Where(x => x.Name.ToLower().StartsWith(name)).ToList();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
