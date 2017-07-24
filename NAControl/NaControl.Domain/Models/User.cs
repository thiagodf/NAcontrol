﻿using NAControl.Common.Resources;
using NAControl.Common.Validation;
using System;

namespace NAControl.Domain.Models
{
    public class User
    {

        #region Ctor

        protected User() { }

        public User(string name, string email)
        {
            this.UseId = Guid.NewGuid();
            this.Name = name;
            this.Email = email;
        }

        #endregion

        #region Properties

        public Guid UseId { get; private set; }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public string Password { get; private set; }

        #endregion

        #region Methods

        public void setPassword(string password, string confirmPassword)
        {
            AssertionConcern.AssertArgumentNotNull(password, Errors.InvalidUserPassword);
            AssertionConcern.AssertArgumentNotNull(confirmPassword, Errors.InvalidUserPassword);
            AssertionConcern.AssertArgumentEquals(password, confirmPassword, Errors.InvalidUserPassword);
            AssertionConcern.AssertArgumentLength(password, 6, 10, Errors.InvalidUserPassword);

            this.Password = PasswordAssertionConcern.Encrypt(password);
        }

        public string resetPassword()
        {
            string password = new Guid().ToString().Substring(0, 8);
            this.Password = PasswordAssertionConcern.Encrypt(password);
            return (password);
        }

        public void ChangeName(string name)
        {
            this.Name = name;
        }

        public void Validate()
        {
            AssertionConcern.AssertArgumentLength(this.Name, 3, 250, Errors.InvalidUserName);
            EmailAssertionConcern.AssertIsValid(this.Email);
            PasswordAssertionConcern.AssertIsValid(this.Password);
        }

        #endregion
    }
}
