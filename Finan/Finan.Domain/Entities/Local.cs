namespace Finan.Domain.Entities
{
    public class Local
    {
        public int LocalId { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }

        // EntityFramework need
        protected Local() { }

        // Create local
        public Local(string description, int userId)
        {
            Description = description;
            UserId = userId;
        }

        // Get Local
        public Local(int localId, string description, int userId)
        {
            LocalId = localId;
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