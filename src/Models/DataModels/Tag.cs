namespace Models.DataModels
{
    public class Tag : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        // Foreign
        public int PostId { get; set; }
    }
}