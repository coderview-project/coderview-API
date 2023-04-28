using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class addedevaluationDatatable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EvaluationDatas",
                table: "EvaluationDatas");

            migrationBuilder.RenameTable(
                name: "EvaluationDatas",
                newName: "t_evaluationDatas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_t_evaluationDatas",
                table: "t_evaluationDatas",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_t_evaluationDatas",
                table: "t_evaluationDatas");

            migrationBuilder.RenameTable(
                name: "t_evaluationDatas",
                newName: "EvaluationDatas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EvaluationDatas",
                table: "EvaluationDatas",
                column: "Id");
        }
    }
}
