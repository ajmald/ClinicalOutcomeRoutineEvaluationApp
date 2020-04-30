using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicalOutcomeRoutineEvaluationApp.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        public string Text { get; set; }
        public string Type { get; set; }
        
    }
}
