using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class removedevaluationValueFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_t_evaluationContents_t_evaluationValues_ValueId",
                table: "t_evaluationContents");

            migrationBuilder.DropIndex(
                name: "IX_t_evaluationContents_ValueId",
                table: "t_evaluationContents");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_t_evaluationContents_ValueId",
                table: "t_evaluationContents",
                column: "ValueId");

            migrationBuilder.AddForeignKey(
                name: "FK_t_evaluationContents_t_evaluationValues_ValueId",
                table: "t_evaluationContents",
                column: "ValueId",
                principalTable: "t_evaluationValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
