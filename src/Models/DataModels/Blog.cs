using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.DataModels
{
    public class Blog : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        // Foreign
        public int OwnerId { get; set; }
        [ForeignKey("BlogId")]
        public IEnumerable<Post> Posts { get; set; }
    }
}