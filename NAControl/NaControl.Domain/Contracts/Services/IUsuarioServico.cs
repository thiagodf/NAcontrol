using NAControl.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAControl.Domain.Contracts.Services
{
    public interface IUsuarioServico : IDisposable
    {
        Usuario Authenticate(string email, string senha);
        Usuario GetByEmail(string email);
        void Register(string nome, string email, string senha, string confirmaSenha);
        void AlterarUsuario(string email, string nome);
        void AlterarSenha(string email, string senha, string novaSenha, string confirmaNovaSenha);
        string ResetSenha(string email);
        List<Usuario> GetByRange(int skip, int take);

    }
}
