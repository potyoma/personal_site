using System;

namespace Models.DataModels
{
    public interface IEntity
    {
        Guid Id { get; set; }
        string Name { get; set; }
    }
}