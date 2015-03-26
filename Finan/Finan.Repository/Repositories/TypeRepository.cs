using System;
using System.Collections.Generic;
using System.Linq;
using Finan.Domain.Contracts.Repositories;
using Finan.Domain.Entities;

namespace Finan.Repository.Repositories
{
    public class TypeRepository : ITypeRepository
    {
        private readonly IList<EnterType> _mock;

        public TypeRepository()
        {
            _mock = new List<EnterType>();
            _mock.Add(new EnterType(1, "Incoming", 1));
            _mock.Add(new EnterType(2, "Outgoind", 1));
            _mock.Add(new EnterType(3, "In", 2));
            _mock.Add(new EnterType(3, "Out", 2));
            _mock.Add(new EnterType(3, "CreditCard", 2));
        }

        public IList<EnterType> Get()
        {
            return _mock.ToList();
        }

        public EnterType GetById(int id)
        {
            return _mock.FirstOrDefault(c => c.TypeId == id);
        }

        public EnterType Create(EnterType item)
        {
            item.TypeId = _mock.Max(c => c.TypeId) + 1;
            _mock.Add(item);
            return item;
        }

        public void Update(EnterType item)
        {
            throw new NotImplementedException();
        }

        public void Delete(EnterType item)
        {
            _mock.Remove(item);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}