﻿using Customers.Docs.Domain.Entities;

namespace Customers.Docs.Application.Contracts.Persistence
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
    }
}
