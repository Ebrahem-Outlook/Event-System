using MediatR;

namespace Event_System.Domain.Core.Events;

public interface IDomainEvent : INotification
{
    Guid Id { get; }

    DateTime OccuerredOn { get; }
}
