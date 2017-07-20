using NaControl.Domain.Models;
using System;
using System.Collections.Generic;

namespace NaControl.Domain.Contracts.Repositories
{
    public interface IUsuarioRepositorio : IDisposable
    {
        Usuario Get(string email);
        Usuario Get(Guid id);
        List<Usuario> Get(int skip, int take);
        void Create(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(Usuario usuario);
    }
}
