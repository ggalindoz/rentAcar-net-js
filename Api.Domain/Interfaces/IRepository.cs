using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> updateAsync(T item);
        Task<T> insertAsync(T item);
        Task<bool> deleteAsync(Guid id);
        Task<T> selectAsync(Guid id);

        Task<IEnumerable<T>> selectAsync();

        Task<bool> existsAsync(Guid id);
    }
}