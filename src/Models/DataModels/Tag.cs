using System;

namespace Models.DataModels
{
    public class Tag : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        // Foreign
        public Guid PostId { get; set; }
    }
}