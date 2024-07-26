using Event_System.Domain.Core.Events;

namespace Event_System.Domain.Customers.Events;

/// <summary>
/// 
/// </summary>
public sealed record CustomerCreatedDomainEvent : DomainEvent
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="customerId"></param>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    /// <param name="email"></param>
    public CustomerCreatedDomainEvent(Guid customerId, string firstName, string lastName, string email)
        : base()
    {
        CustomerId = customerId;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    /// <summary>
    /// 
    /// </summary>
    public Guid CustomerId { get; }

    /// <summary>
    /// 
    /// </summary>
    public string FirstName { get; }

    /// <summary>
    /// 
    /// </summary>
    public string LastName { get; }

    /// <summary>
    /// 
    /// </summary>
    public string Email { get; }
}
