using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    GradeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Section = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    GradeId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.GradeId);
                    table.ForeignKey(
                        name: "FK_Grades_Grades_GradeId1",
                        column: x => x.GradeId1,
                        principalTable: "Grades",
                        principalColumn: "GradeId");
                    table.ForeignKey(
                        name: "FK_Grades_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "DateOfBirth", "Height", "StudentName", "Weight" },
                values: new object[,]
                {
                    { 1, new DateTime(2003, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 185.5m, "Pero Perić", 91.5f },
                    { 2, new DateTime(2004, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 167.5m, "Ana Anić", 62.3f }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "GradeId", "GradeId1", "GradeName", "Section", "StudentId" },
                values: new object[,]
                {
                    { 1, null, "Odličan", "Geografija", 1 },
                    { 2, null, "Vrlo dobar", "Matematika", 1 },
                    { 3, null, "Odličan", "Povijest", 1 },
                    { 4, null, "Dobar", "Geografija", 2 },
                    { 5, null, "Vrlo dobar", "Matematika", 2 },
                    { 6, null, "Odličan", "Povijest", 2 },
                    { 7, null, "Dobar", "Engleski jezik", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grades_GradeId1",
                table: "Grades",
                column: "GradeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentId",
                table: "Grades",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
