using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;
using ClinicalOutcomeRoutineEvaluationApp.Models;

namespace ClinicalOutcomeRoutineEvaluationApp.ViewModels
{
    public class QuestionAnswerViewModel
    {
        public DateTime Date { get;set; }
        public List<Question> Questions { get; set; }

        public List<Answer> Answers { get; set; }
    }
}
