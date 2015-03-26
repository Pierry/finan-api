using System.Collections.Generic;
using Finan.Domain.Contracts.Business;
using Finan.Domain.Contracts.Repositories;
using Finan.Domain.Entities;

namespace Finan.Services.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public IList<Item> Get(int page)
        {
            return _itemRepository.Get();
        }

        public Item GetById(int id)
        {
            return _itemRepository.GetById(id);
        }

        public Item Create(decimal total, string title, string description, int userId, int localId, int typeId)
        {
            var item = new Item(total, title, description, userId, localId, typeId);
            return _itemRepository.Create(item);
        }

        public void ChangeDetails(int itemId, string title, string description, decimal total)
        {
            Item item = GetById(itemId);
            item.ChangeDetails(title, description, total);
            _itemRepository.Update(item);
        }

        public void ChangeLocal(int itemId, int localId)
        {
            Item item = GetById(itemId);
            item.ChangeLocal(localId);
            _itemRepository.Update(item);
        }

        public void ChangeType(int itemId, int typeId)
        {
            Item item = GetById(itemId);
            item.ChangeType(typeId);
            _itemRepository.Update(item);
        }

        public void Delete(int itemId)
        {
            var item = GetById(itemId);
            _itemRepository.Delete(item);
        }

        public void Dispose()
        {
            _itemRepository.Dispose();
        }
    }
}