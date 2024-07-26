using MediatR;

namespace Event_System.Application.Core.Abstractions.Messaging;

public interface IQueryHandler<in TRequest> : IRequestHandler<TRequest>
    where TRequest : IQuery
{

}

public interface IQueryHandler<in TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
    where TRequest : IQuery<TResponse>
    where TResponse : class
{

}
