using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CgpaProject.Migrations
{
    public partial class wert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SecondSubjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SecondSubjectName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondSubjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    FirstNumber = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FirstNumberGrade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstNumberPoint = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SecondSubjectId = table.Column<int>(type: "int", nullable: false),
                    SecondNumber = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SecondNumberGrade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondNumberPoint = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalNumber = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalPoint = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalGrade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Results_SecondSubjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "SecondSubjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Results_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Results_SubjectId",
                table: "Results",
                column: "SubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "SecondSubjects");

            migrationBuilder.DropTable(
                name: "Subjects");
        }
    }
}
