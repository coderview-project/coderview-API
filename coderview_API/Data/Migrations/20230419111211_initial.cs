using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_evaluationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "t_evaluationValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_evaluationValues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "t_files",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FileExtension = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_files", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "t_userRols",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_userRols", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "t_users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRolId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EncryptedPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EncryptedToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TokenExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_t_users_t_userRols_UserRolId",
                        column: x => x.UserRolId,
                        principalTable: "t_userRols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_evaluations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EvaluateeUserId = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    ValueId = table.Column<int>(type: "int", nullable: false),
                    ContentId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_evaluations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_t_evaluations_t_evaluationStates_StateId",
                        column: x => x.StateId,
                        principalTable: "t_evaluationStates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_evaluations_t_evaluationTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "t_evaluationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_evaluations_t_evaluationValues_ValueId",
                        column: x => x.ValueId,
                        principalTable: "t_evaluationValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_evaluations_t_users_EvaluateeUserId",
                        column: x => x.EvaluateeUserId,
                        principalTable: "t_users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_evaluations_t_users_UserId",
                        column: x => x.UserId,
                        principalTable: "t_users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t_evaluationContents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EvaluationId = table.Column<int>(type: "int", nullable: false),
                    ContentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_evaluationContents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_t_evaluationContents_t_evaluations_EvaluationId",
                        column: x => x.EvaluationId,
                        principalTable: "t_evaluations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_t_evaluationContents_EvaluationId",
                table: "t_evaluationContents",
                column: "EvaluationId");

            migrationBuilder.CreateIndex(
                name: "IX_t_evaluations_EvaluateeUserId",
                table: "t_evaluations",
                column: "EvaluateeUserId");

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

            migrationBuilder.CreateIndex(
                name: "IX_t_evaluations_ValueId",
                table: "t_evaluations",
                column: "ValueId");

            migrationBuilder.CreateIndex(
                name: "IX_t_users_UserRolId",
                table: "t_users",
                column: "UserRolId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_bootcampContents");

            migrationBuilder.DropTable(
                name: "t_evaluationContents");

            migrationBuilder.DropTable(
                name: "t_files");

            migrationBuilder.DropTable(
                name: "t_evaluations");

            migrationBuilder.DropTable(
                name: "t_evaluationStates");

            migrationBuilder.DropTable(
                name: "t_evaluationTypes");

            migrationBuilder.DropTable(
                name: "t_evaluationValues");

            migrationBuilder.DropTable(
                name: "t_users");

            migrationBuilder.DropTable(
                name: "t_userRols");
        }
    }
}
