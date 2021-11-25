using EntrevistaApp.Domain.Entities;
using System.Collections.Generic;
using MediatR;
using EntrevistaApp.Application.Abstraction;

namespace EntrevistaApp.Application.Abstraction.Questao.Commands
{
    public class AtualizarQuestaoCommand : IRequest<CommandExecution>
    {
        public int Id
        {
            get;
            set;
        }

        public string Enunciado
        {
            get;
            set;
        }

        public byte Nivel
        {
            get;
            set;
        }

        public byte Tipo
        {
            get;
            set;
        }

        public ICollection<EntrevistaApp.Domain.Entities.QuestaoQuestionario> QuestaoQuestionario
        {
            get;
            set;
        }
    }
}