using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.DataModels
{
    public class Owner : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }

        // Foreign 
        [ForeignKey("OwnerId")]
        public IEnumerable<Skill> Skills { get; set; }
        [ForeignKey("OwnerId")]
        public IEnumerable<Post> Posts { get; set; }
        [ForeignKey("OwnerId")]
        public Blog Blog { get; set; }
    }
}