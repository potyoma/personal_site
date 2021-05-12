using System;

namespace Models.DataModels
{
    public class Image : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public byte[] ImageBinary { get; set; }
    }
}