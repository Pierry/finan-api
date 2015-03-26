using System;
using System.Collections.Generic;
using Finan.Domain.Entities;

namespace Finan.Domain.Contracts.Business
{
    public interface IItemService : IDisposable
    {
        IList<Item> Get(int page);
        Item GetById(int id);

        Item Create(decimal total, string title, string description,
            int userId, int localId, int typeId);

        void ChangeDetails(int itemId, string title, string description, decimal total);
        void ChangeLocal(int itemId, int localId);
        void ChangeType(int itemId, int typeId);
        void Delete(int itemId);
    }
}