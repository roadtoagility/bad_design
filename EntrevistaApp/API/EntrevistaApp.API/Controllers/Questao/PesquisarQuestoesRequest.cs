using EntrevistaApp.Application.Abstraction.Questao.Querys;

namespace EntrevistaApp.API.Controllers.Questao
{
    public class PesquisarQuestoesRequest
    {
        public PesquisarQuestoesQuery ToQuery()
        {
            return new PesquisarQuestoesQuery();
        }
    }
}