using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.DataModels
{
    public class Post : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime? Posted { get; set; }
        
        // Foreign
        public int CoverId { get; set; }
        public int OwnerId { get; set; }
        public int BlogId { get; set; }
        [ForeignKey("PostId")]
        public IEnumerable<Tag> Tags { get; set; }
    }
}