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
        private readonly CoreDbContext _context;
        

        public HomeController(ILogger<HomeController> logger, CoreDbContext context) 
        {
            _logger = logger;
            _context = context;
       
        }

        public IActionResult Index()
        {
            return View(); 
        }

        

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Questionnaire()
        {
            List<Question> _questions = _context.Questions.ToList();
            List<Answer> _answers = _context.Answers.ToList();


            QuestionAnswerViewModel _questionAnswerVM = new QuestionAnswerViewModel()
            {
                Date = DateTime.Today,
                Random = new Random(),
                Questions = _questions,
                Answers = _answers
            };


            return View(_questionAnswerVM);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
