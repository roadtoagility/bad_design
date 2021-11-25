using System;
using System.Collections.Generic;

namespace EntrevistaApp.Domain.Entities
{
    public partial class QuestaoQuestionario
    {
        public int Id { get; set; }
        public int IdQuestao { get; set; }
        public int IdQuestionario { get; set; }

        public virtual Questao IdQuestaoNavigation { get; set; }
        public virtual Questionario IdQuestionarioNavigation { get; set; }
    }
}
