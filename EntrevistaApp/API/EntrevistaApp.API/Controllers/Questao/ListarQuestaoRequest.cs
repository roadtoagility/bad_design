using EntrevistaApp.Application.Abstraction.Questao.Querys;

namespace EntrevistaApp.API.Controllers.Questao
{
    public class ListarQuestaoRequest
    {
        public ListarQuestaoQuery ToQuery()
        {
            return new ListarQuestaoQuery();
        }
    }
}