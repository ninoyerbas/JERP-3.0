using System;
using Microsoft.EntityFrameworkCore.Migrations;
using JERP.Infrastructure.Data.Seeders;

#nullable disable

namespace JERP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddFASBASCSupport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FASBReference",
                schema: "dbo",
                table: "Accounts",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FASBSubtopicId",
                schema: "dbo",
                table: "Accounts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FASBTopicId",
                schema: "dbo",
                table: "Accounts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FASBTopics",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TopicCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TopicName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    IsSuperseded = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FASBTopics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FASBSubtopics",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FASBTopicId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubtopicCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SubtopicName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    IsRepealed = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FASBSubtopics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FASBSubtopics_FASBTopics_FASBTopicId",
                        column: x => x.FASBTopicId,
                        principalSchema: "dbo",
                        principalTable: "FASBTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_FASBSubtopicId",
                schema: "dbo",
                table: "Accounts",
                column: "FASBSubtopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_FASBTopicId",
                schema: "dbo",
                table: "Accounts",
                column: "FASBTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_FASBSubtopics_FASBTopicId",
                schema: "dbo",
                table: "FASBSubtopics",
                column: "FASBTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_FASBSubtopics_TopicId_SubtopicCode",
                schema: "dbo",
                table: "FASBSubtopics",
                columns: new[] { "FASBTopicId", "SubtopicCode" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FASBTopics_Category",
                schema: "dbo",
                table: "FASBTopics",
                column: "Category");

            migrationBuilder.CreateIndex(
                name: "IX_FASBTopics_TopicCode",
                schema: "dbo",
                table: "FASBTopics",
                column: "TopicCode",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_FASBSubtopics_FASBSubtopicId",
                schema: "dbo",
                table: "Accounts",
                column: "FASBSubtopicId",
                principalSchema: "dbo",
                principalTable: "FASBSubtopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_FASBTopics_FASBTopicId",
                schema: "dbo",
                table: "Accounts",
                column: "FASBTopicId",
                principalSchema: "dbo",
                principalTable: "FASBTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_FASBSubtopics_FASBSubtopicId",
                schema: "dbo",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_FASBTopics_FASBTopicId",
                schema: "dbo",
                table: "Accounts");

            migrationBuilder.DropTable(
                name: "FASBSubtopics",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "FASBTopics",
                schema: "dbo");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_FASBSubtopicId",
                schema: "dbo",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_FASBTopicId",
                schema: "dbo",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "FASBReference",
                schema: "dbo",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "FASBSubtopicId",
                schema: "dbo",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "FASBTopicId",
                schema: "dbo",
                table: "Accounts");
        }
    }
}
