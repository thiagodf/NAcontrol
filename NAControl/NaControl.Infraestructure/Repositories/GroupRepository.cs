using NAControl.Domain.Contracts.Repositories;
using NAControl.Domain.Models;
using NAControl.Infraestructure.Data;
using System.Collections.Generic;
using System.Linq;

namespace NAControl.Infraestructure.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        private AppDataContext _context;

        public GroupRepository(AppDataContext _context)
        {
            this._context = _context;
        }

        public Group Get(string name)
        {
            return _context.Groups.Where(x => x.Name.ToLower() == name.ToLower()).FirstOrDefault();
        }

        public Group Get(int id)
        {
            return _context.Groups.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Group> Get(int skip, int take)
        {
            return _context.Groups.OrderBy(x => x.Name).Skip(skip).Take(take).ToList();
        }

        public void Create(Group Group)
        {
            _context.Groups.Add(Group);
            _context.SaveChanges(); ;
        }

        public void Update(Group Group)
        {
            _context.Entry<Group>(Group).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(Group Group)
        {
            _context.Groups.Remove(Group);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
