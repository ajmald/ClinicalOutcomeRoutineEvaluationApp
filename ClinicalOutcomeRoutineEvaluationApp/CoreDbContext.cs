using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicalOutcomeRoutineEvaluationApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicalOutcomeRoutineEvaluationApp
{
    public class CoreDbContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public CoreDbContext(DbContextOptions<CoreDbContext> options)
           : base(options)
        {
        }

      
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=coreApp.db");






        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            List<Question> _questions = new List<Question>();
            List<Answer> _answers = new List<Answer>();

            _answers.Add(new Answer { Id = 1, Text = "Pas du tout", Score = 0 });
            _answers.Add(new Answer { Id = 2, Text = "Rarement", Score = 1 });
            _answers.Add(new Answer { Id = 3, Text = "Quelques fois", Score = 2 });
            _answers.Add(new Answer { Id = 4, Text = "Souvent", Score = 3 });
            _answers.Add(new Answer { Id = 5, Text = "La plupart du temps", Score = 4 });

            _questions.Add(new Question { Id = 1, Text = "Je me suis senti terriblement seul et isolé", Type = "F"});
            _questions.Add(new Question { Id = 2, Text = "J’ai été anxieux et nerveux", Type = "P"});
            _questions.Add(new Question { Id = 3, Text = "J'ai pensé pouvoir me tourner vers quelqu'un quand j'avais besoin", Type = "F"});
            _questions.Add(new Question { Id = 4, Text = "Je me suis senti bien", Type = "W" });
            _questions.Add(new Question { Id = 5, Text = "J’ai pensé manquer d'énergie et d'enthousiame", Type = "P"});
            _questions.Add(new Question { Id = 6, Text = "J'ai été physiquement violent envers les autres", Type = "R"});
            _questions.Add(new Question { Id = 7, Text = "Je me suis senti capable de me debrouiller quand les choses n'allaient pas", Type = "F"});
            _questions.Add(new Question { Id = 8, Text = "J'ai eu des douleurs physiques divers", Type = "W"});
            _questions.Add(new Question { Id = 9, Text = "J'ai pensé à me fair du mal", Type = "R"});
            _questions.Add(new Question { Id = 10, Text = "Parler aux autres était un grand effort à faire", Type = "F"});
            _questions.Add(new Question { Id = 11, Text = "La tension et l’anxiété m’ont empeché d’avancer sur certains sujets importants", Type = "P"});
            _questions.Add(new Question { Id = 12, Text = "J’ai été satisfait avec les choses que j’ai fait", Type = "F"});
            _questions.Add(new Question { Id = 13, Text = "J’ai été perturbé par des pensées négatives", Type = "P"});
            _questions.Add(new Question { Id = 14, Text = "J’ai voulu pleurer plusieurs fois", Type = "W"});
            _questions.Add(new Question { Id = 15, Text = "J’ai ressenti de la panique ou de la terreur", Type = "P"});
            _questions.Add(new Question { Id = 16, Text = "J’ai eu des idées suicidaires", Type = "R"});
            _questions.Add(new Question { Id = 17, Text = "J’ai été submergés de problèmes", Type = "W"});
            _questions.Add(new Question { Id = 18, Text = "J’ai eu des difficultés insurmontables", Type = "W"});
            _questions.Add(new Question { Id = 19, Text = "J’ai eu du mal à me coucher ou à retrouver le sommeil", Type = "P"});
            _questions.Add(new Question { Id = 20, Text = "J’ai ressenti de la chaleur et de l’affection envers quelqu’un", Type = "F" });
            _questions.Add(new Question { Id = 21, Text = "Mes problèmes étaient devenus ingérables", Type = "P"});
            _questions.Add(new Question { Id = 22, Text = "J’ai pu faire les choses que j’avais à faire", Type = "F"});
            _questions.Add(new Question { Id = 23, Text = "J’ai ménacé ou intimidé quelqu’un d’autre", Type = "R"});
            _questions.Add(new Question { Id = 24, Text = "J’ai perdu espoir", Type = "P"});
            _questions.Add(new Question { Id = 25, Text = "J’ai pensé qu’il serait mieux que je sois mort", Type = "R"});
            _questions.Add(new Question { Id = 26, Text = "J’ai senti un critique des autres envers moi", Type = "F" });
            _questions.Add(new Question { Id = 27, Text = "J’ai pensé que je n’avais pas d’amis", Type = "F" });
            _questions.Add(new Question { Id = 28, Text = "Je me suis senti triste", Type = "P"});
            _questions.Add(new Question { Id = 29, Text = "J’ai été hanté par des images et des souvenirs", Type = "P" });
            _questions.Add(new Question { Id = 30, Text = "J’ai été irritable envers les autres", Type = "F" });
            _questions.Add(new Question { Id = 31, Text = "J’ai pensé que j’étais le seul responsable de mes problèmes et difficultés ", Type = "P" });
            _questions.Add(new Question { Id = 32, Text = "J’ai ressenti de l’optimisme pour l’avenir", Type = "W" });
            _questions.Add(new Question { Id = 33, Text = "J’ai pu réalisé les choses que je voulais", Type = "F" });
            _questions.Add(new Question { Id = 34, Text = "J’ai pensé avoir été humilié par les autres", Type = "F" });
            _questions.Add(new Question { Id = 35, Text = "Je me suis fait du mal physiquement et j’ai pris des risques inconsidérés pour ma vie", Type = "R"});

            modelBuilder.Entity<Answer>().HasData(_answers);
            modelBuilder.Entity<Question>().HasData(_questions);
        
        
        
        
        }


        }



}
