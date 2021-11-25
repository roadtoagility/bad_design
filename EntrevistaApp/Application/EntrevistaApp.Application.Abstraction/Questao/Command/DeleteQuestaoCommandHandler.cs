using EntrevistaApp.Application.Abstraction.Questao.Commands;
using System.Threading.Tasks;
using System;
using MediatR;
using System.Threading;

namespace EntrevistaApp.Application.Abstraction.Questao.Command
{
    public class DeleteQuestaoCommandHandler : IRequestHandler<DeleteQuestaoCommand, CommandExecution>
    {
        public async Task<CommandExecution> Handle(DeleteQuestaoCommand command, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Command handler não implementado");
        }
    }
}