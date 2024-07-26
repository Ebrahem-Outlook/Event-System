using MediatR;

namespace Event_System.Application.Core.Abstractions.Messaging;

public interface ICommand : IRequest
{

}

public interface ICommand<out TResponse> : IRequest<TResponse>
    where TResponse : class
{

}
