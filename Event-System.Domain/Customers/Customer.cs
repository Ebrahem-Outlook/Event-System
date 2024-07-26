using Event_System.Domain.Core.BaseType;
using Event_System.Domain.Customers.Events;

namespace Event_System.Domain.Customers;

public sealed class Customer : AggregateRoot
{
    private string _passwordHash = default!;

    private Customer(string firstName, string lastName, string email, string passwordHash)
        : base(Guid.NewGuid())
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        _passwordHash = passwordHash;
    }

    private Customer() { }

    public string FirstName { get; private set; } = default!;
    public string LastName { get; private set; } = default!;
    public string Email { get; private set; } = default!;

    public static Customer Create(string firstName, string lastName, string email, string passwordHash)
    {
        Customer customer = new(firstName, lastName, email, passwordHash);

        customer.RaiseDomainEvent(new );

        return customer;
    }

    public void Update(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;

        RaiseDomainEvent(new CustomerUpdatedDomainEvent(Id, FirstName, LastName));
    }

    public void UpdateEmail(string email)
    {
        Email = email;

        RaiseDomainEvent(new CustomerEmailUpdatedDomainEvent(Id, Email));
    }

    public void UpdatePassword(string passwordHash)
    {
        _passwordHash = passwordHash;

        RaiseDomainEvent(new CustomerPasswordUpdatedDomainEvent(Id));
    }
}
