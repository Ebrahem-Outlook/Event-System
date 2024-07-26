using Event_System.Domain.Core.BaseType;

namespace Event_System.Domain.Customers;

public interface ICustomerRepository : IRepository
{
    // Commands.
    Task AddAsync(Customer product, CancellationToken cancellationToken = default);
    void Update(Customer product);
    void Delete(Customer product);

    // Queries.
    Task<List<Customer>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Customer> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<List<Customer>> GetByNameAsync(string name, CancellationToken cancellationToken = default);
}
