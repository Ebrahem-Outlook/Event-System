using MediatR;

namespace Event_System.Application.Core.Abstractions.Messaging;

public interface IQuery : IRequest
{

}

public interface IQuery<out TResponse> : IRequest<TResponse>
    where TResponse : class
{

}
