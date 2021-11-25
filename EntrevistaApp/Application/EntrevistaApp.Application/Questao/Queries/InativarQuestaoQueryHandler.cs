using EntrevistaApp.Application.Abstraction.Questao.Querys;
using EntrevistaApp.Application.Abstraction.Questao.Responses;
using System.Threading.Tasks;
using System;
using MediatR;
using System.Threading;

namespace EntrevistaApp.Application.Questao.Queries
{
    public class InativarQuestaoQueryHandler : IRequestHandler<InativarQuestaoQuery, InativarQuestaoResponse>
    {
        public async Task<InativarQuestaoResponse> Handle(InativarQuestaoQuery query, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Query handler não implementado");
        }
    }
}