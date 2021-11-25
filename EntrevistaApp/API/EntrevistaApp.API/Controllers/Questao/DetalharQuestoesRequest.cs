using EntrevistaApp.Application.Abstraction.Questao.Querys;

namespace EntrevistaApp.API.Controllers.Questao
{
    public class DetalharQuestoesRequest
    {
        public DetalharQuestoesQuery ToQuery()
        {
            return new DetalharQuestoesQuery();
        }
    }
}