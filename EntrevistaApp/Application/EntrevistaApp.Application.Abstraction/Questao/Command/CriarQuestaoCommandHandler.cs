using EntrevistaApp.Application.Abstraction.Questao.Commands;
using System.Threading.Tasks;
using System;
using MediatR;
using System.Threading;

namespace EntrevistaApp.Application.Abstraction.Questao.Command
{
    public class CriarQuestaoCommandHandler : IRequestHandler<CriarQuestaoCommand, CommandExecution>
    {
        public async Task<CommandExecution> Handle(CriarQuestaoCommand command, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Command handler não implementado");
        }
    }
}