using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.DataModels
{
    public class Post : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime? Posted { get; set; }

        // Foreign
        public Guid CoverId { get; set; }
        public Guid OwnerId { get; set; }
        public Guid BlogId { get; set; }
        [ForeignKey("PostId")]
        public IEnumerable<Tag> Tags { get; set; }
    }
}