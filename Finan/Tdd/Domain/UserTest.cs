using System;
using Finan.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tdd.Domain
{
    [TestClass]
    public class UserTest
    {
        private readonly User _user;
        
        public UserTest()
        {
            _user = new User("pieerry@gmail.com");
        }

        [TestMethod]
        public void SetPassword()
        {
            _user.SetPassword("123123", "123123");
        }

        [TestMethod]
        public void UpdateLogOn()
        {
            _user.UpdateLogOn(DateTime.Now);
        }

        [TestMethod]
        public void ChangeStatus()
        {
            _user.ChangeStatus(true);
        }

        [TestMethod]
        public void ResetPassword()
        {
            _user.ResetPassword("123123", "222222", "222222");
        }
    }
}
