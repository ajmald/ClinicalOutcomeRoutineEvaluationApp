﻿// <auto-generated />
using ClinicalOutcomeRoutineEvaluationApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClinicalOutcomeRoutineEvaluationApp.Migrations
{
    [DbContext(typeof(CoreDbContext))]
    [Migration("20200430194429_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("ClinicalOutcomeRoutineEvaluationApp.Models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Score")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Score = 0,
                            Text = "Pas du tout"
                        },
                        new
                        {
                            Id = 2,
                            Score = 1,
                            Text = "Rarement"
                        },
                        new
                        {
                            Id = 3,
                            Score = 2,
                            Text = "Quelques fois"
                        },
                        new
                        {
                            Id = 4,
                            Score = 3,
                            Text = "Souvent"
                        },
                        new
                        {
                            Id = 5,
                            Score = 4,
                            Text = "La plupart du temps"
                        });
                });

            modelBuilder.Entity("ClinicalOutcomeRoutineEvaluationApp.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Text = "Je me suis senti terriblement seul et isolé",
                            Type = "F"
                        },
                        new
                        {
                            Id = 2,
                            Text = "J’ai été anxieux et nerveux",
                            Type = "P"
                        },
                        new
                        {
                            Id = 3,
                            Text = "J'ai pensé pouvoir me tourner vers quelqu'un quand j'avais besoin",
                            Type = "F"
                        },
                        new
                        {
                            Id = 4,
                            Text = "Je me suis senti bien",
                            Type = "W"
                        },
                        new
                        {
                            Id = 5,
                            Text = "J’ai pensé manquer d'énergie et d'enthousiame",
                            Type = "P"
                        },
                        new
                        {
                            Id = 6,
                            Text = "J'ai été physiquement violent envers les autres",
                            Type = "R"
                        },
                        new
                        {
                            Id = 7,
                            Text = "Je me suis senti capable de me debrouiller quand les choses n'allaient pas",
                            Type = "F"
                        },
                        new
                        {
                            Id = 8,
                            Text = "J'ai eu des douleurs physiques divers",
                            Type = "W"
                        },
                        new
                        {
                            Id = 9,
                            Text = "J'ai pensé à me fair du mal",
                            Type = "R"
                        },
                        new
                        {
                            Id = 10,
                            Text = "Parler aux autres était un grand effort à faire",
                            Type = "F"
                        },
                        new
                        {
                            Id = 11,
                            Text = "La tension et l’anxiété m’ont empeché d’avancer sur certains sujets importants",
                            Type = "P"
                        },
                        new
                        {
                            Id = 12,
                            Text = "J’ai été satisfait avec les choses que j’ai fait",
                            Type = "F"
                        },
                        new
                        {
                            Id = 13,
                            Text = "J’ai été perturbé par des pensées négatives",
                            Type = "P"
                        },
                        new
                        {
                            Id = 14,
                            Text = "J’ai voulu pleurer plusieurs fois",
                            Type = "W"
                        },
                        new
                        {
                            Id = 15,
                            Text = "J’ai ressenti de la panique ou de la terreur",
                            Type = "P"
                        },
                        new
                        {
                            Id = 16,
                            Text = "J’ai eu des idées suicidaires",
                            Type = "R"
                        },
                        new
                        {
                            Id = 17,
                            Text = "J’ai été submergés de problèmes",
                            Type = "W"
                        },
                        new
                        {
                            Id = 18,
                            Text = "J’ai eu des difficultés insurmontables",
                            Type = "W"
                        },
                        new
                        {
                            Id = 19,
                            Text = "J’ai eu du mal à me coucher ou à retrouver le sommeil",
                            Type = "P"
                        },
                        new
                        {
                            Id = 20,
                            Text = "J’ai ressenti de la chaleur et de l’affection envers quelqu’un",
                            Type = "F"
                        },
                        new
                        {
                            Id = 21,
                            Text = "Mes problèmes étaient devenus ingérables",
                            Type = "P"
                        },
                        new
                        {
                            Id = 22,
                            Text = "J’ai pu faire les choses que j’avais à faire",
                            Type = "F"
                        },
                        new
                        {
                            Id = 23,
                            Text = "J’ai ménacé ou intimidé quelqu’un d’autre",
                            Type = "R"
                        },
                        new
                        {
                            Id = 24,
                            Text = "J’ai perdu espoir",
                            Type = "P"
                        },
                        new
                        {
                            Id = 25,
                            Text = "J’ai pensé qu’il serait mieux que je sois mort",
                            Type = "R"
                        },
                        new
                        {
                            Id = 26,
                            Text = "J’ai senti un critique des autres envers moi",
                            Type = "F"
                        },
                        new
                        {
                            Id = 27,
                            Text = "J’ai pensé que je n’avais pas d’amis",
                            Type = "F"
                        },
                        new
                        {
                            Id = 28,
                            Text = "Je me suis senti triste",
                            Type = "P"
                        },
                        new
                        {
                            Id = 29,
                            Text = "J’ai été hanté par des images et des souvenirs",
                            Type = "P"
                        },
                        new
                        {
                            Id = 30,
                            Text = "J’ai été irritable envers les autres",
                            Type = "F"
                        },
                        new
                        {
                            Id = 31,
                            Text = "J’ai pensé que j’étais le seul responsable de mes problèmes et difficultés ",
                            Type = "P"
                        },
                        new
                        {
                            Id = 32,
                            Text = "J’ai ressenti de l’optimisme pour l’avenir",
                            Type = "W"
                        },
                        new
                        {
                            Id = 33,
                            Text = "J’ai pu réalisé les choses que je voulais",
                            Type = "F"
                        },
                        new
                        {
                            Id = 34,
                            Text = "J’ai pensé avoir été humilié par les autres",
                            Type = "F"
                        },
                        new
                        {
                            Id = 35,
                            Text = "Je me suis fait du mal physiquement et j’ai pris des risques inconsidérés pour ma vie",
                            Type = "R"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
