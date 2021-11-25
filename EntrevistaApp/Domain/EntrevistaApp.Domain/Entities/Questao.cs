using System;
using System.Collections.Generic;

namespace EntrevistaApp.Domain.Entities
{
    public partial class Questao
    {
        public Questao()
        {
            QuestaoQuestionario = new HashSet<QuestaoQuestionario>();
        }

        public int Id { get; set; }
        public string Enunciado { get; set; }
        public byte Nivel { get; set; }
        public byte Tipo { get; set; }

        public virtual ICollection<QuestaoQuestionario> QuestaoQuestionario { get; set; }
    }
}
