﻿using Event_System.Application.Core.Abstractions.Data;
using Event_System.Domain.Customers;
using Microsoft.Extensions.Caching.Memory;

namespace Event_System.Persistence.Caching;

internal sealed class CachedCustomerRepository(IDbContext dbContext, IMemoryCache memoryCache) : ICustomerRepository
{
    public Task AddAsync(Customer product, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void Update(Customer product)
    {
        throw new NotImplementedException();
    }

    public void Delete(Customer product)
    {
        throw new NotImplementedException();
    }

    public Task<List<Customer>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Customer> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<List<Customer>> GetByNameAsync(string name, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
