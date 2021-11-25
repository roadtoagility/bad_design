using System.Collections.Generic;
using System.Threading.Tasks;
using EntrevistaApp.Domain.Entities;
using EntrevistaApp.Infrastructure.Repository.Repositories;
using EntrevistaApp.Infrastructure.Repository.Context;

namespace EntrevistaApp.Domain.Repositories
{
    public class QuestaoRepository : RepositoryBase<Questao>, IQuestaoRepository
    {
        public QuestaoRepository(BD_EntrevistaAppContext context): base(context)
        {
        }
    }
}