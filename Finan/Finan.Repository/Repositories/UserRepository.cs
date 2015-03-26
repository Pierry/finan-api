using System;
using System.Collections.Generic;
using System.Linq;
using Finan.Domain.Contracts.Repositories;
using Finan.Domain.Entities;

namespace Finan.Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IList<User> _mock;

        public UserRepository()
        {
            _mock = new List<User>();
            _mock.Add(new User(1, "pieerry@gmail.com", "123123", DateTime.Now, DateTime.Now, true));
            _mock.Add(new User(2, "jessika@gmail.com", "1111111", DateTime.Now, DateTime.Now, true));
            _mock.Add(new User(3, "darlan@gmail.com", "2222222", DateTime.Now, DateTime.Now, false));
            _mock.Add(new User(4, "dani@gmail.com", "3233333", DateTime.Now, DateTime.Now, true));
            _mock.Add(new User(5, "pedro@gmail.com", "8728728", DateTime.Now, DateTime.Now, false));
            _mock.Add(new User(6, "joao@gmail.com", "0902190290", DateTime.Now, DateTime.Now, true));
            _mock.Add(new User(7, "jose@gmail.com", "123123", DateTime.Now, DateTime.Now, true));
        }

        public IList<User> Get()
        {
            return _mock.ToList();
        }

        public User GetById(int id)
        {
            return _mock.FirstOrDefault(c => c.UserId == id);
        }

        public User Create(User item)
        {
            item.UserId = _mock.Max(c => c.UserId) + 1;
            _mock.Add(item);
            
            return item;
        }

        public void Update(User item)
        {
            throw new NotImplementedException();
        }

        public void Delete(User item)
        {
            _mock.Remove(item);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}