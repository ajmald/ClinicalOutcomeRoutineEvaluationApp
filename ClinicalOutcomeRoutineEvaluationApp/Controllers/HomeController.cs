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
            return View(); 
        }

        



        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Questionnaire()
        {

            _answers.Add(new Answer { Text = "Pas du tout", Score = 0 });
            _answers.Add(new Answer { Text = "Rarement", Score = 1 });
            _answers.Add(new Answer { Text = "Quelques fois", Score = 2 });
            _answers.Add(new Answer { Text = "Souvent", Score = 3 });
            _answers.Add(new Answer { Text = "La plupart du temps", Score = 4 });

            _questions.Add(new Question { Text = "Je me sens terriblement seul et isolé", Type = "F", Answers = _answers });
            _questions.Add(new Question { Text = "J’ai été anxieux et nerveux", Type = "P", Answers = _answers });
            _questions.Add(new Question { Text = "J'ai pensé pouvoir me tourner vers quelqu'un quand j'avais besoin", Type = "F", Answers = _answers });
            _questions.Add(new Question { Text = "Je me suis senti bien", Type = "W", Answers = _answers });
            _questions.Add(new Question { Text = "J’ai pensé manquer d'énergie et d'enthousiame", Type = "P", Answers = _answers });
            _questions.Add(new Question { Text = "J'ai été physiquement violent envers les autres", Type = "R", Answers = _answers });
            _questions.Add(new Question { Text = "Je me suis senti capable de me debrouiller quand les choses n'allaient pas", Type = "F", Answers = _answers });
            _questions.Add(new Question { Text = "J'ai eu des douleurs physiques divers", Type = "W", Answers = _answers });
            _questions.Add(new Question { Text = "J'ai pensé à me fair du mal", Type = "R", Answers = _answers });
            _questions.Add(new Question { Text = "Parler aux autres était un grand effort à faire", Type = "F", Answers = _answers });
            _questions.Add(new Question { Text = "La tension et l’anxiété m’ont empeché d’avancer sur certains sujets importants", Type = "P", Answers = _answers });
            _questions.Add(new Question { Text = "J’ai été satisfait avec les choses que j’ai fait", Type = "F", Answers = _answers });
            _questions.Add(new Question { Text = "J’ai été perturbé par des pensées négatives", Type = "P", Answers = _answers });
            _questions.Add(new Question { Text = "J’ai voulu pleurer plusieurs fois", Type = "W", Answers = _answers });
            _questions.Add(new Question { Text = "J’ai ressenti de la panique ou de la terreur", Type = "P", Answers = _answers });
            _questions.Add(new Question { Text = "J’ai eu des idées suicidaires", Type = "R", Answers = _answers });
            _questions.Add(new Question { Text = "J’ai été submergés de problèmes", Type = "W", Answers = _answers });
            _questions.Add(new Question { Text = "J’ai eu des difficultés insurmontables", Type = "W", Answers = _answers });
            _questions.Add(new Question { Text = "J’ai eu du mal à me coucher ou à retrouver le sommeil", Type = "P", Answers = _answers });
            _questions.Add(new Question { Text = "J’ai ressenti de la chaleur et de l’affection envers quelqu’un", Type = "F", Answers = _answers });
            _questions.Add(new Question { Text = "Mes problèmes étaient devenus ingérables", Type = "P", Answers = _answers });
            _questions.Add(new Question { Text = "J’ai pu faire les choses que j’avais à faire", Type = "F", Answers = _answers });
            _questions.Add(new Question { Text = "J’ai ménacé ou intimidé quelqu’un d’autre", Type = "R", Answers = _answers });
            _questions.Add(new Question { Text = "J’ai perdu espoir", Type = "P", Answers = _answers });
            _questions.Add(new Question { Text = "J’ai pensé qu’il serait mieux que je sois mort", Type = "R", Answers = _answers });
            _questions.Add(new Question { Text = "J’ai senti un critique des autres envers moi", Type = "F", Answers = _answers });
            _questions.Add(new Question { Text = "J’ai pensé que je n’avais pas d’amis", Type = "F", Answers = _answers });
            _questions.Add(new Question { Text = "Je me suis senti triste", Type = "P", Answers = _answers });
            _questions.Add(new Question { Text = "J’ai été hanté par des images et des souvenirs", Type = "P", Answers = _answers });
            _questions.Add(new Question { Text = "J’ai été irritable envers les autres", Type = "F", Answers = _answers });
            _questions.Add(new Question { Text = "J’ai pensé que j’étais le seul responsable de mes problèmes et difficultés ", Type = "P", Answers = _answers });
            _questions.Add(new Question { Text = "J’ai ressenti de l’optimisme pour l’avenir", Type = "W", Answers = _answers });
            _questions.Add(new Question { Text = "J’ai pu réalisé les choses que je voulais", Type = "F", Answers = _answers });
            _questions.Add(new Question { Text = "J’ai pensé avoir été humilié par les autres", Type = "F", Answers = _answers });
            _questions.Add(new Question { Text = "Je me suis fait du mal physiquement et j’ai pris des risques inconsidérés pour ma vie", Type = "R", Answers = _answers });

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
