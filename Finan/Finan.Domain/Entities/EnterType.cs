namespace Finan.Domain.Entities
{
    public class EnterType
    {
        public int TypeId { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }

        // EntityFramework needs
        protected EnterType() { }

        // Create EnterType
        public EnterType(string description, int userId)
        {
            Description = description;
            UserId = userId;
        }

        // Get EnterType
        public EnterType(int typeId, string description, int userId)
        {
            TypeId = typeId;
            Description = description;
            UserId = userId;
        }

        public void ChangeDescription(string description)
        {
            Description = description;
        }

        public void IsValid()
        {
            
        }
    }
}