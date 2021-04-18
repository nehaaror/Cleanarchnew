using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Core.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.infra.bus
{
   public sealed class InMemorybus : IMediatorhandler
    {
        private readonly IMediator _mediator;
        public InMemorybus( IMediator mediator)
        {
            _mediator = mediator;
        }
    
        public Task Sendcommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }
    }
}
