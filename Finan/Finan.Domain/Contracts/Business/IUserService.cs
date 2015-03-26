using System;
using System.Collections.Generic;
using Finan.Domain.Entities;

namespace Finan.Domain.Contracts.Business
{
    public interface IUserService : IDisposable
    {
        IList<User> Get(int page);
        User GetById(int id);
        User Create(string email, string password, string confirmPassword);
        void UpdateLogOn(int userId, DateTime lastDate);
        void ChangeStatus(int userId);
        void ResetPassword(int userId, string oldPassword, string newPassword, string confirmPassword);
    }
}