using System;
using System.Collections.Generic;
using System.Linq;
using Finan.Domain.Contracts.Repositories;
using Finan.Domain.Entities;

namespace Finan.Repository.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly IList<Item> _mock;

        public ItemRepository()
        {
            _mock = new List<Item>();
            _mock.Add(new Item(1, new decimal(10.0), "Food", "", DateTime.Now, 1, 1, 1));
            _mock.Add(new Item(2, new decimal(20.0), "Meat", "", DateTime.Now, 1, 1, 1));
            _mock.Add(new Item(3, new decimal(13.0), "Shopping", "", DateTime.Now, 1, 1, 1));
            _mock.Add(new Item(4, new decimal(16.0), "PC Parts", "", DateTime.Now, 1, 1, 1));
            _mock.Add(new Item(5, new decimal(11.0), "MousePad", "", DateTime.Now, 1, 1, 1));
            _mock.Add(new Item(6, new decimal(6.0), "USB Cable", "", DateTime.Now, 1, 1, 1));
        }

        public IList<Item> Get()
        {
            return _mock.ToList();
        }

        public Item GetById(int id)
        {
            return _mock.FirstOrDefault(c => c.ItemId == id);
        }

        public Item Create(Item item)
        {
            item.ItemId = _mock.Max(c => c.ItemId) + 1;
            _mock.Add(item);
            return item;
        }

        public void Update(Item item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Item item)
        {
            _mock.Remove(item);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}