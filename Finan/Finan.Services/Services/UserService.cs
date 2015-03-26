using System;
using System.Collections.Generic;
using Finan.Domain.Contracts.Business;
using Finan.Domain.Contracts.Repositories;
using Finan.Domain.Entities;

namespace Finan.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IList<User> Get(int page)
        {
            return _userRepository.Get();
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public User Create(string email, string password, string confirmPassword)
        {
            var user = new User(email);
            user.SetPassword(password, confirmPassword);
            return _userRepository.Create(user);
        }

        public void UpdateLogOn(int userId, DateTime lastDate)
        {
            var user = GetById(userId);
            user.UpdateLogOn(DateTime.Now);
            _userRepository.Update(user);
        }

        public void ChangeStatus(int userId)
        {
            var user = GetById(userId);
            user.ChangeStatus(!user.IsActive);
            _userRepository.Update(user);
        }

        public void ResetPassword(int userId, string oldPassword, string newPassword, string confirmPassword)
        {
            var user = GetById(userId);
            user.ResetPassword(user.Password, newPassword, confirmPassword);
            _userRepository.Update(user);
        }

        public void Dispose()
        {
            _userRepository.Dispose();
        }
    }
}