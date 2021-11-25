using EntrevistaApp.Application.Abstraction.Questao.Querys;
using EntrevistaApp.Application.Abstraction.Questao.Responses;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using EntrevistaApp.Domain.Repositories;
using System.Linq;

namespace EntrevistaApp.Application.Questao.Queries
{
    public class ListarQuestaoQueryHandler : IRequestHandler<ListarQuestaoQuery, ListarQuestaoResponse>
    {
        public ListarQuestaoQueryHandler(IQuestaoRepository repository)
        {
            _repository = repository;
        }

        private IQuestaoRepository _repository
        {
            get;
        }

        public async Task<ListarQuestaoResponse> Handle(ListarQuestaoQuery query, CancellationToken cancellationToken)
        {
            var entidades = _repository.List();
            var response = ListarQuestaoResponse.From(entidades.ToList());
            return await Task.FromResult(response);
        }
    }
}