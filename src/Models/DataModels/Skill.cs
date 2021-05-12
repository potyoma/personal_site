using System;
using System.ComponentModel.DataAnnotations;

namespace Models.DataModels
{
    public class Skill : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        [Range(0, 101)]
        public int Level { get; set; }

        // Foreign
        public Guid OwnerId { get; set; }
    }
}