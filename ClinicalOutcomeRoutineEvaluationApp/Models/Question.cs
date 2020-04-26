using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalOutcomeRoutineEvaluationApp.Models
{
    public class Question
    {
        private string text;
        private string type;
        private List<Answer> answers;

        public string Text { get => text; set => text = value; }
        public string Type { get => type; set => type = value; }
        public List<Answer> Answers { get => answers; set => answers = value; }
    }
}
