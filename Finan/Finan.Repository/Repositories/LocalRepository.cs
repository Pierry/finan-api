using System;
using System.Collections.Generic;
using System.Linq;
using Finan.Domain.Contracts.Repositories;
using Finan.Domain.Entities;

namespace Finan.Repository.Repositories
{
    public class LocalRepository : ILocalRepository
    {
        private readonly IList<Local> _mock;

        public LocalRepository()
        {
            _mock = new List<Local>();
            _mock.Add(new Local(1, "Market", 1));
            _mock.Add(new Local(2, "Gas Station", 1));
            _mock.Add(new Local(3, "Car", 1));
            _mock.Add(new Local(4, "Home", 1));
            _mock.Add(new Local(5, "Market", 2));
            _mock.Add(new Local(6, "Meat", 2));
            _mock.Add(new Local(7, "Gas", 2));
            _mock.Add(new Local(8, "Coffee", 2));
            _mock.Add(new Local(9, "Market", 3));
            _mock.Add(new Local(10, "Hobby", 3));
        }

        public IList<Local> Get()
        {
            return _mock.ToList();
        }

        public Local GetById(int id)
        {
            return _mock.FirstOrDefault(c => c.LocalId == id);
        }

        public Local Create(Local item)
        {
            item.LocalId = _mock.Max(c => c.LocalId) + 1;
            _mock.Add(item);
            return item;
        }

        public void Update(Local item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Local item)
        {
            _mock.Remove(item);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}