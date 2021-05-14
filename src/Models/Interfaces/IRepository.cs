using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Models.DataModels;

namespace Models.Interfaces
{
    public interface IRepository
    {
        Task<IEnumerable<T>> GetAllAsync<T>() where T : class, IEntity;
        Task<T> GetByIdAsync<T>(Guid id) where T : class, IEntity;
        Task<T> CreateAsync<T>(T model) where T : class, IEntity;
        Task<T> UpdateAsync<T>(Guid id, T model) where T : class, IEntity;
        Task<bool> DeleteAsync<T>(Guid id) where T : class, IEntity;
    }
}