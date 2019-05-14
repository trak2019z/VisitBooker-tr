﻿using MediatR;

namespace Domain.Core.Command
{
    public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
           where TCommand : ICommand<TResponse>
    {
    }

    public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand>
           where TCommand : ICommand
    {
    }
}
