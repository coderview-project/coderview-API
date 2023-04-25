using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class fixedrelationsstructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_t_evaluations_t_evaluationStates_StateId",
                table: "t_evaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_t_evaluations_t_evaluationTypes_TypeId",
                table: "t_evaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_t_evaluations_t_evaluationValues_ValueId",
                table: "t_evaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_t_evaluations_t_users_UserId",
                table: "t_evaluations");

            migrationBuilder.DropTable(
                name: "t_bootcampContents");

            migrationBuilder.DropTable(
                name: "t_evaluationStates");

            migrationBuilder.DropTable(
                name: "t_evaluationTypes");

            migrationBuilder.DropIndex(
                name: "IX_t_evaluations_StateId",
                table: "t_evaluations");

            migrationBuilder.DropIndex(
                name: "IX_t_evaluations_TypeId",
                table: "t_evaluations");

            migrationBuilder.DropIndex(
                name: "IX_t_evaluations_UserId",
                table: "t_evaluations");

            migrationBuilder.DropColumn(
                name: "Actions",
                table: "t_skills");

            migrationBuilder.DropColumn(
                name: "Criteria",
                table: "t_skills");

            migrationBuilder.DropColumn(
                name: "ContentId",
                table: "t_evaluations");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "t_evaluations");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "t_evaluations");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "t_evaluations");

            migrationBuilder.RenameColumn(
                name: "Level",
                table: "t_evaluationValues",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "ValueId",
                table: "t_evaluations",
                newName: "EvaluatorId");

            migrationBuilder.RenameColumn(
                name: "FinishDate",
                table: "t_evaluations",
                newName: "EndDate");

            migrationBuilder.RenameIndex(
                name: "IX_t_evaluations_ValueId",
                table: "t_evaluations",
                newName: "IX_t_evaluations_EvaluatorId");

            migrationBuilder.AddColumn<int>(
                name: "Title",
                table: "t_evaluationValues",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ValueId",
                table: "t_evaluationContents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "t_bootcamps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_bootcamps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_t_bootcamps_t_users_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "t_users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_bootcampStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BootcampId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_bootcampStudents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_t_bootcampStudents_t_bootcamps_BootcampId",
                        column: x => x.BootcampId,
                        principalTable: "t_bootcamps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_t_evaluationContents_ContentId",
                table: "t_evaluationContents",
                column: "ContentId");

            migrationBuilder.CreateIndex(
                name: "IX_t_evaluationContents_ValueId",
                table: "t_evaluationContents",
                column: "ValueId");

            migrationBuilder.CreateIndex(
                name: "IX_t_bootcamps_CreatorId",
                table: "t_bootcamps",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_t_bootcampStudents_BootcampId",
                table: "t_bootcampStudents",
                column: "BootcampId");

            migrationBuilder.AddForeignKey(
                name: "FK_t_evaluationContents_t_contents_ContentId",
                table: "t_evaluationContents",
                column: "ContentId",
                principalTable: "t_contents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_t_evaluationContents_t_evaluationValues_ValueId",
                table: "t_evaluationContents",
                column: "ValueId",
                principalTable: "t_evaluationValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_t_evaluations_t_users_EvaluatorId",
                table: "t_evaluations",
                column: "EvaluatorId",
                principalTable: "t_users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_t_evaluationContents_t_contents_ContentId",
                table: "t_evaluationContents");

            migrationBuilder.DropForeignKey(
                name: "FK_t_evaluationContents_t_evaluationValues_ValueId",
                table: "t_evaluationContents");

            migrationBuilder.DropForeignKey(
                name: "FK_t_evaluations_t_users_EvaluatorId",
                table: "t_evaluations");

            migrationBuilder.DropTable(
                name: "t_bootcampStudents");

            migrationBuilder.DropTable(
                name: "t_bootcamps");

            migrationBuilder.DropIndex(
                name: "IX_t_evaluationContents_ContentId",
                table: "t_evaluationContents");

            migrationBuilder.DropIndex(
                name: "IX_t_evaluationContents_ValueId",
                table: "t_evaluationContents");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "t_evaluationValues");

            migrationBuilder.DropColumn(
                name: "ValueId",
                table: "t_evaluationContents");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "t_evaluationValues",
                newName: "Level");

            migrationBuilder.RenameColumn(
                name: "EvaluatorId",
                table: "t_evaluations",
                newName: "ValueId");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "t_evaluations",
                newName: "FinishDate");

            migrationBuilder.RenameIndex(
                name: "IX_t_evaluations_EvaluatorId",
                table: "t_evaluations",
                newName: "IX_t_evaluations_ValueId");

            migrationBuilder.AddColumn<string>(
                name: "Actions",
                table: "t_skills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Criteria",
                table: "t_skills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ContentId",
                table: "t_evaluations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StateId",
                table: "t_evaluations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "t_evaluations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "t_evaluations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "t_bootcampContents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BootcampId = table.Column<int>(type: "int", nullable: false),
                    ContentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_bootcampContents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "t_evaluationStates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_evaluationStates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "t_evaluationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_evaluationTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_t_evaluations_StateId",
                table: "t_evaluations",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_t_evaluations_TypeId",
                table: "t_evaluations",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_t_evaluations_UserId",
                table: "t_evaluations",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_t_evaluations_t_evaluationStates_StateId",
                table: "t_evaluations",
                column: "StateId",
                principalTable: "t_evaluationStates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_t_evaluations_t_evaluationTypes_TypeId",
                table: "t_evaluations",
                column: "TypeId",
                principalTable: "t_evaluationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_t_evaluations_t_evaluationValues_ValueId",
                table: "t_evaluations",
                column: "ValueId",
                principalTable: "t_evaluationValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_t_evaluations_t_users_UserId",
                table: "t_evaluations",
                column: "UserId",
                principalTable: "t_users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
