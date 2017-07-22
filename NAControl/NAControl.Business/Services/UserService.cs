﻿using NAControl.Common.Resources;
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
    public class UserService : IUserServico
    {
        private IUserRepositorio _repository;

        public UserService(IUserRepositorio repository)
        {
            this._repository = repository;
        }

        public User Authenticate(string email, string senha)
        {
            var User = GetByEmail(email);

            if (User.Senha != /*PasswordAssertionConcern.Encrypt(senha)*/ "")
                throw new Exception(/*Errors.InvalidCredentials*/ "");

            return User;
        }

        public void AlterarUser(string email, string nome)
        {
            var User = GetByEmail(email);

            User.AlteraNome(nome);
            User.Validar();

            _repository.Update(User);
        }

        public void AlterarSenha(string email, string password, string newSenha, string confirmaNovaSenha)
        {
            var User = Authenticate(email, password);

            User.InformarSenha(newSenha, confirmaNovaSenha);
            User.Validar();

            _repository.Update(User);
        }

        public void Register(string nome, string email, string senha, string confirmaSenha)
        {
            var hasUser = _repository.Get(email);
            if (hasUser != null)
                throw new Exception(/*Errors.DuplicateEmail*/"");

            var User = new User(nome, email);
            User.InformarSenha(senha, confirmaSenha);
            User.Validar();

            _repository.Create(User);
        }

        public User GetByEmail(string email)
        {
            var User = _repository.Get(email);
            if (User == null)
                throw new Exception(/*Errors.UserNotFound*/"");

            return User;
        }

        public string ResetSenha(string email)
        {
            var User = GetByEmail(email);
            var senha = User.ResetarSenha();
            User.Validar();

            _repository.Update(User);
            return senha;
        }

        public List<User> GetByRange(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
