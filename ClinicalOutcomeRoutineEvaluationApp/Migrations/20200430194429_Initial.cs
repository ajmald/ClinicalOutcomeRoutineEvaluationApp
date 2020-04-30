using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicalOutcomeRoutineEvaluationApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(nullable: true),
                    Score = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Score", "Text" },
                values: new object[] { 1, 0, "Pas du tout" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Score", "Text" },
                values: new object[] { 2, 1, "Rarement" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Score", "Text" },
                values: new object[] { 3, 2, "Quelques fois" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Score", "Text" },
                values: new object[] { 4, 3, "Souvent" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Score", "Text" },
                values: new object[] { 5, 4, "La plupart du temps" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 20, "J’ai ressenti de la chaleur et de l’affection envers quelqu’un", "F" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 21, "Mes problèmes étaient devenus ingérables", "P" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 22, "J’ai pu faire les choses que j’avais à faire", "F" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 23, "J’ai ménacé ou intimidé quelqu’un d’autre", "R" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 24, "J’ai perdu espoir", "P" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 25, "J’ai pensé qu’il serait mieux que je sois mort", "R" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 26, "J’ai senti un critique des autres envers moi", "F" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 28, "Je me suis senti triste", "P" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 19, "J’ai eu du mal à me coucher ou à retrouver le sommeil", "P" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 29, "J’ai été hanté par des images et des souvenirs", "P" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 30, "J’ai été irritable envers les autres", "F" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 31, "J’ai pensé que j’étais le seul responsable de mes problèmes et difficultés ", "P" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 32, "J’ai ressenti de l’optimisme pour l’avenir", "W" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 33, "J’ai pu réalisé les choses que je voulais", "F" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 27, "J’ai pensé que je n’avais pas d’amis", "F" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 18, "J’ai eu des difficultés insurmontables", "W" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 15, "J’ai ressenti de la panique ou de la terreur", "P" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 16, "J’ai eu des idées suicidaires", "R" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 1, "Je me suis senti terriblement seul et isolé", "F" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 2, "J’ai été anxieux et nerveux", "P" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 3, "J'ai pensé pouvoir me tourner vers quelqu'un quand j'avais besoin", "F" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 4, "Je me suis senti bien", "W" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 5, "J’ai pensé manquer d'énergie et d'enthousiame", "P" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 6, "J'ai été physiquement violent envers les autres", "R" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 7, "Je me suis senti capable de me debrouiller quand les choses n'allaient pas", "F" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 8, "J'ai eu des douleurs physiques divers", "W" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 9, "J'ai pensé à me fair du mal", "R" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 10, "Parler aux autres était un grand effort à faire", "F" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 11, "La tension et l’anxiété m’ont empeché d’avancer sur certains sujets importants", "P" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 12, "J’ai été satisfait avec les choses que j’ai fait", "F" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 13, "J’ai été perturbé par des pensées négatives", "P" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 14, "J’ai voulu pleurer plusieurs fois", "W" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 34, "J’ai pensé avoir été humilié par les autres", "F" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 17, "J’ai été submergés de problèmes", "W" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text", "Type" },
                values: new object[] { 35, "Je me suis fait du mal physiquement et j’ai pris des risques inconsidérés pour ma vie", "R" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
