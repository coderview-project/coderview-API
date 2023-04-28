using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class addedevaluationdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EvaluationDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectM = table.Column<int>(type: "int", nullable: false),
                    FuncTech1 = table.Column<int>(type: "int", nullable: false),
                    FuncTech2 = table.Column<int>(type: "int", nullable: false),
                    FuncTech3 = table.Column<int>(type: "int", nullable: false),
                    Front1 = table.Column<int>(type: "int", nullable: false),
                    Front2 = table.Column<int>(type: "int", nullable: false),
                    Back1 = table.Column<int>(type: "int", nullable: false),
                    Back2 = table.Column<int>(type: "int", nullable: false),
                    Archit = table.Column<int>(type: "int", nullable: false),
                    Qa1 = table.Column<int>(type: "int", nullable: false),
                    Qa2 = table.Column<int>(type: "int", nullable: false),
                    Qa3 = table.Column<int>(type: "int", nullable: false),
                    EvaluatorId = table.Column<int>(type: "int", nullable: false),
                    EvaluateeId = table.Column<int>(type: "int", nullable: false),
                    EvaluationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationDatas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EvaluationDatas");
        }
    }
}
