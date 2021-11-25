using EntrevistaApp.Application.Abstraction.Questao.Querys;

namespace EntrevistaApp.API.Controllers.Questao
{
    public class InativarQuestaoRequest
    {
        public InativarQuestaoQuery ToQuery()
        {
            return new InativarQuestaoQuery();
        }
    }
}