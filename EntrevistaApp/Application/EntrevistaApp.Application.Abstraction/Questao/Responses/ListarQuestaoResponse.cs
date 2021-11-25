using Entities =  EntrevistaApp . Domain . Entities ;
using System.Collections.Generic;

namespace EntrevistaApp.Application.Abstraction.Questao.Responses
{
    public class ListarQuestaoResponse
    {
        public IList<Entities.Questao> Entities
        {
            get;
            set;
        }

        public ListarQuestaoResponse(IList<Entities.Questao> entities)
        {
            Entities = entities;
        }

        public static ListarQuestaoResponse From(IList<Entities.Questao> entities)
        {
            return new ListarQuestaoResponse(entities);
        }
    }
}