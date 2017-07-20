using NaControl.Domain.Contracts.Repositories;
using NaControl.Domain.Models;
using NaControl.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NaControl.Infraestructure.Repositories
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private AppDataContext _context;

        public UsuarioRepositorio(AppDataContext context)
        {
            this._context = context;
        }

        public Usuario Get(string email)
        {
            return _context.Usuarios.Where(x => x.Email.ToLower() == email.ToLower()).FirstOrDefault();
        }

        public Usuario Get(Guid id)
        {
            return _context.Usuarios.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Usuario> Get(int skip, int take)
        {
            return _context.Usuarios.OrderBy(x => x.Nome).Skip(skip).Take(take).ToList();
        }

        public void Create(Usuario Usuario)
        {
            _context.Usuarios.Add(Usuario);
            _context.SaveChanges();
        }

        public void Update(Usuario Usuario)
        {
            _context.Entry<Usuario>(Usuario).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(Usuario Usuario)
        {
            _context.Usuarios.Remove(Usuario);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
