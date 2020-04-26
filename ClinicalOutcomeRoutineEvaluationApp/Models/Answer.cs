using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalOutcomeRoutineEvaluationApp.Models
{
    public class Answer
    {
        private string text;
        private int score;

        public string Text { get => text; set => text = value; }
        public int Score { get => score; set => score = value; }

    }
}
