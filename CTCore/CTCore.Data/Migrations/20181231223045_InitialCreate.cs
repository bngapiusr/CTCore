using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CTCore.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassType",
                columns: table => new
                {
                    ClassTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 20, nullable: true),
                    Description = table.Column<string>(maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassType", x => x.ClassTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Instructor",
                columns: table => new
                {
                    InstructorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 30, nullable: true),
                    LastName = table.Column<string>(maxLength: 30, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor", x => x.InstructorId);
                });

            migrationBuilder.CreateTable(
                name: "StudentClass",
                columns: table => new
                {
                    StudentClassId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InstructorId = table.Column<int>(nullable: false),
                    ClassTypeId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 30, nullable: true),
                    LastName = table.Column<string>(maxLength: 30, nullable: true),
                    Rank = table.Column<string>(maxLength: 20, nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    TkdBod = table.Column<DateTime>(nullable: false),
                    LastTestDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentClass", x => x.StudentClassId);
                    table.ForeignKey(
                        name: "FK_StudentClass_ClassType_ClassTypeId",
                        column: x => x.ClassTypeId,
                        principalTable: "ClassType",
                        principalColumn: "ClassTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentClass_Instructor_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructor",
                        principalColumn: "InstructorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentClass_ClassTypeId",
                table: "StudentClass",
                column: "ClassTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClass_InstructorId",
                table: "StudentClass",
                column: "InstructorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentClass");

            migrationBuilder.DropTable(
                name: "ClassType");

            migrationBuilder.DropTable(
                name: "Instructor");
        }
    }
}
