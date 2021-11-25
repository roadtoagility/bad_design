using System.Collections.Generic;
using System.Threading.Tasks;
using EntrevistaApp.Domain.Entities;

namespace EntrevistaApp.Domain.Repositories
{
    public interface IQuestaoRepository
    {
        IEnumerable<Questao> List();
        void Add(Questao entity);
        void Update(int id, Questao entity);
        void Delete(int id);
    }
}