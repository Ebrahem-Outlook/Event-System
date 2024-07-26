using MediatR;

namespace Event_System.Application.Core.Abstractions.Messaging;

public interface ICommandHandler<in TRequest> : IRequestHandler<TRequest>
    where TRequest : ICommand
{
    
}


public interface ICommandHandler<in TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
    where TRequest : ICommand<TResponse>
    where TResponse : class
{

}
