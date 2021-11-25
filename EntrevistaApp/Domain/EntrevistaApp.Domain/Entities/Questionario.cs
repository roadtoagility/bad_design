using System;
using System.Collections.Generic;

namespace EntrevistaApp.Domain.Entities
{
    public partial class Questionario
    {
        public Questionario()
        {
            QuestaoQuestionario = new HashSet<QuestaoQuestionario>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public byte Nivel { get; set; }

        public virtual ICollection<QuestaoQuestionario> QuestaoQuestionario { get; set; }
    }
}
