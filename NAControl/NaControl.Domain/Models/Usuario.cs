using NaControl.Common.Resources;
using NaControl.Common.Validation;
using NAControl.Common.Validation;
using System;

namespace NaControl.Domain.Models
{
    public class Usuario
    {
        #region Ctor
        protected Usuario() { }
        public Usuario(string nome, string email)
        {
            this.Id = Guid.NewGuid();
            this.Nome = nome;
            this.Email = email;
        }
        #endregion

        #region Properties
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        #endregion

        #region Methods
        public void InformarSenha(string senha, string confirmacao)
        {
            AssertionConcern.AssertArgumentNotNull(senha, Errors.InvalidUserPassword);
            AssertionConcern.AssertArgumentNotNull(confirmacao, Errors.InvalidUserPassword);
            AssertionConcern.AssertArgumentLength(senha, 6, 20, Errors.InvalidUserPassword);
            AssertionConcern.AssertArgumentEquals(senha, confirmacao, Errors.PasswordDoesNotMatch);

            this.Senha = PasswordAssertionConcern.Encrypt(senha);
        }
        public string ResetarSenha()
        {
            string password = Guid.NewGuid().ToString().Substring(0, 8);
            this.Senha = PasswordAssertionConcern.Encrypt(password);

            return Senha;
        }
        public void AlteraNome(string nome)
        {
            this.Nome = nome;
        }
        public void Validar()
        {
            AssertionConcern.AssertArgumentLength(this.Nome, 3, 250, Errors.InvalidUserName);
            EmailAssertionConcern.AssertIsValid(this.Email);
            PasswordAssertionConcern.AssertIsValid(this.Senha);
        }
        #endregion
    }
}
