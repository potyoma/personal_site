namespace Models.DataModels
{
    public class Image : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] ImageBinary { get; set; }
    }
}