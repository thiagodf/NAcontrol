using NAControl.Domain.Models;
using System;
using System.Collections.Generic;

namespace NAControl.Domain.Contracts.Services
{
    public interface IUserService : IDisposable
    {
        User Authenticate(string email, string senha);
        User GetByEmail(string email);
        void Register(string name, string email, string password, string confirmPassword);
        void ChangeUser(string email, string nome);
        void ChangePassword(string email, string password, string newPassword, string confirmPassword);
        string ResetPassword(string email);
        List<User> GetByRange(int skip, int take);

    }
}
