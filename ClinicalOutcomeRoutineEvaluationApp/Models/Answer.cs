using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ClinicalOutcomeRoutineEvaluationApp.Models
{
    
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public int Score { get; set; }

    }
}
