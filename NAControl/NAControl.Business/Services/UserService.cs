using NAControl.Common.Resources;
using NAControl.Common.Validation;
using NAControl.Domain.Contracts.Repositories;
using NAControl.Domain.Contracts.Services;
using NAControl.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAControl.Business.Services
{
    public class UserService : IUsuarioServico
    {
        private IUsuarioRepositorio _repository;

        public UserService(IUsuarioRepositorio repository)
        {
            this._repository = repository;
        }

        public Usuario Authenticate(string email, string senha)
        {
            var usuario = GetByEmail(email);

            if (usuario.Senha != /*PasswordAssertionConcern.Encrypt(senha)*/ "")
                throw new Exception(/*Errors.InvalidCredentials*/ "");

            return usuario;
        }

        public void AlterarUsuario(string email, string nome)
        {
            var usuario = GetByEmail(email);

            usuario.AlteraNome(nome);
            usuario.Validar();

            _repository.Update(usuario);
        }

        public void AlterarSenha(string email, string password, string newSenha, string confirmaNovaSenha)
        {
            var usuario = Authenticate(email, password);

            usuario.InformarSenha(newSenha, confirmaNovaSenha);
            usuario.Validar();

            _repository.Update(usuario);
        }

        public void Register(string nome, string email, string senha, string confirmaSenha)
        {
            var hasUsuario = _repository.Get(email);
            if (hasUsuario != null)
                throw new Exception(/*Errors.DuplicateEmail*/"");

            var usuario = new Usuario(nome, email);
            usuario.InformarSenha(senha, confirmaSenha);
            usuario.Validar();

            _repository.Create(usuario);
        }

        public Usuario GetByEmail(string email)
        {
            var usuario = _repository.Get(email);
            if (usuario == null)
                throw new Exception(/*Errors.UserNotFound*/"");

            return usuario;
        }

        public string ResetSenha(string email)
        {
            var usuario = GetByEmail(email);
            var senha = usuario.ResetarSenha();
            usuario.Validar();

            _repository.Update(usuario);
            return senha;
        }

        public List<Usuario> GetByRange(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
