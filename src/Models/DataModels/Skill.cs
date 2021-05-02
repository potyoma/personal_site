using System.ComponentModel.DataAnnotations;

namespace Models.DataModels
{
    public class Skill : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Range(0, 101)]
        public int Level { get; set; }
        
        // Foreign
        public int OwnerId { get; set; }
    }
}