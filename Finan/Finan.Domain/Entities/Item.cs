using System;

namespace Finan.Domain.Entities
{
    public class Item
    {
        public int ItemId { get; set; }
        public decimal Total { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserId { get; set; }
        public int LocalId { get; set; }
        public int TypeId { get; set; }
        public virtual User User { get; set; }
        public virtual Local Local { get; set; }
        public virtual EnterType EnterType { get; set; }

        // EntityFramework needs
        protected Item() { }

        // Create Item
        public Item(decimal total, string title, string description, 
            int userId, int localId, int typeId)
        {
            Total = total;
            Title = title;
            Description = description;
            CreateDate = DateTime.Now;
            UserId = userId;
            LocalId = localId;
            TypeId = typeId;
        }

        // Get Item
        public Item(int itemId, decimal total, string title, string description,
            DateTime createDate, int userId, int localId, int typeId)
        {
            ItemId = itemId;
            Total = total;
            Title = title;
            Description = description;
            CreateDate = createDate;
            UserId = userId;
            LocalId = localId;
            TypeId = typeId;
        }

        public void ChangeDetails(string title, string description, decimal total)
        {
            Title = title;
            Description = description;
            Total = total;
        }

        public void ChangeLocal(int localId)
        {
            LocalId = localId;
        }

        public void ChangeType(int typeId)
        {
            TypeId = typeId;
        }

        public void IsValid()
        {
            
        }
    }
}
