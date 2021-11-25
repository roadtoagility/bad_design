using EntrevistaApp.Application.Abstraction.Questao.Commands;
using System.Threading.Tasks;
using System;
using MediatR;
using System.Threading;
using Entities =  EntrevistaApp . Domain . Entities ;
using EntrevistaApp.Domain.Repositories;

namespace EntrevistaApp.Application.Abstraction.Questao.Command
{
    public class AtualizarQuestaoCommandHandler : IRequestHandler<AtualizarQuestaoCommand, CommandExecution>
    {
        public AtualizarQuestaoCommandHandler(IQuestaoRepository repository)
        {
            _repository = repository;
        }

        private IQuestaoRepository _repository
        {
            get;
        }

        public async Task<CommandExecution> Handle(AtualizarQuestaoCommand command, CancellationToken cancellationToken)
        {
            var entity = new Entities.Questao();
            entity.Id = command.Id;
            entity.Enunciado = command.Enunciado;
            entity.Nivel = command.Nivel;
            entity.Tipo = command.Tipo;
            entity.QuestaoQuestionario = command.QuestaoQuestionario;
            _repository.Update(entity.Id, entity);
            return await Task.FromResult(CommandExecution.From());
        }
    }
}