using NAControl.Domain.Contracts.Repositories;
using NAControl.Domain.Models;
using NAControl.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NAControl.Infraestructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private AppDataContext _context;

        public UserRepository(AppDataContext context)
        {
            this._context = context;
        }

        public User Get(string email)
        {
            return _context.Users.Where(x => x.Email.ToLower() == email.ToLower()).FirstOrDefault();
        }

        public User Get(Guid id)
        {
            return _context.Users.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<User> Get(int skip, int take)
        {
            return _context.Users.OrderBy(x => x.Name).Skip(skip).Take(take).ToList();
        }

        public void Create(User User)
        {
            _context.Users.Add(User);
            _context.SaveChanges();
        }

        public void Update(User User)
        {
            _context.Entry<User>(User).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(User User)
        {
            _context.Users.Remove(User);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
