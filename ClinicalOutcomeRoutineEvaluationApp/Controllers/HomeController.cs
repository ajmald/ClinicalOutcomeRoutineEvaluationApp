using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ClinicalOutcomeRoutineEvaluationApp.Models;
using ClinicalOutcomeRoutineEvaluationApp.ViewModels;

using Microsoft.AspNetCore.Mvc.Rendering;


namespace ClinicalOutcomeRoutineEvaluationApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        List<Question> _questions = new List<Question>();
        List<Answer> _answers = new List<Answer>();

        public HomeController(ILogger<HomeController> logger) 
        {
            _logger = logger;
       
        }

        public IActionResult Index()
        {
            
            _answers.Add(new Answer { Text = "Pas du tout", Score = 0 });
            _answers.Add(new Answer { Text = "Rarement", Score = 1 });
            _answers.Add(new Answer { Text = "Quelques fois", Score = 2 });
            _answers.Add(new Answer { Text = "Souvent", Score = 3 });
            _answers.Add(new Answer { Text = "La plupart du temps", Score = 4 });

            _questions.Add(new Question { Text = "Je me sens terriblement seul et isole", Type = "F", Answers = _answers });
            _questions.Add(new Question { Text = "Je suis anxieux et nerveux", Type = "P", Answers = _answers });
            _questions.Add(new Question { Text = "J'ai senti pouvoir me tourner vers quelqu'un quand j'avais besoin", Type = "F", Answers = _answers });
            _questions.Add(new Question { Text = "Je me sens bien", Type = "W", Answers = _answers });
            _questions.Add(new Question { Text = "Je pense manquer d'energie et d'enthousiame", Type = "P", Answers = _answers });

            QuestionAnswerViewModel _questionAnswerVM = new QuestionAnswerViewModel()
            {
                Date = DateTime.Today,
                Questions = _questions,
                Answers = _answers
            };


            return View(_questionAnswerVM);
        }

   

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
