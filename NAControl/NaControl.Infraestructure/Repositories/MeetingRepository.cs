using NAControl.Domain.Contracts.Repositories;
using NAControl.Domain.Models;
using NAControl.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NAControl.Infraestructure.Repositories
{
    public class MeetingRepository : RepositoryBase<Meeting>, IMeetingRepository
    {
        //AppDataContext _context;

        //public MeetingRepository(AppDataContext _context)
        //{
        //    this._context = _context;
        //}

        //public Meeting Get(Group group)
        //{
        //    return _context.Meetings.Where(x => x.Group == group).FirstOrDefault();
        //}

        //public Meeting Get(int id)
        //{
        //    return _context.Meetings.Where(x => x.MeeId == id).FirstOrDefault();
        //}

        //public List<Meeting> Get(int skip, int take)
        //{
        //    return _context.Meetings.OrderBy(x => x.Group).Skip(skip).Take(take).ToList();
        //}

        //public void Create(Meeting Meeting)
        //{
        //    _context.Meetings.Add(Meeting);
        //    _context.SaveChanges();
        //}

        //public void Update(Meeting Meeting)
        //{
        //    _context.Entry<Meeting>(Meeting).State = System.Data.Entity.EntityState.Modified;
        //    _context.SaveChanges();
        //}

        //public void Delete(Meeting Meeting)
        //{
        //    _context.Meetings.Remove(Meeting);
        //    _context.SaveChanges();
        //}

        //public void Dispose()
        //{
        //    _context.Dispose();
        //}
        public MeetingRepository(AppDataContext _context) : base(_context)
        {
        }
    }
}
