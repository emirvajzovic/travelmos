using Microsoft.EntityFrameworkCore.Migrations;

namespace travelmos.Migrations
{
    public partial class dbFixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tourist_Language_LanguageId",
                table: "Tourist");

            migrationBuilder.RenameColumn(
                name: "LanguageId",
                table: "Tourist",
                newName: "SecondaryLanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_Tourist_LanguageId",
                table: "Tourist",
                newName: "IX_Tourist_SecondaryLanguageId");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "User",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrimaryLanguageId",
                table: "Tourist",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrimaryLanguageId",
                table: "Guide",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SecondaryLanguageId",
                table: "Guide",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tourist_PrimaryLanguageId",
                table: "Tourist",
                column: "PrimaryLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Guide_PrimaryLanguageId",
                table: "Guide",
                column: "PrimaryLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Guide_SecondaryLanguageId",
                table: "Guide",
                column: "SecondaryLanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Guide_Language_PrimaryLanguageId",
                table: "Guide",
                column: "PrimaryLanguageId",
                principalTable: "Language",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Guide_Language_SecondaryLanguageId",
                table: "Guide",
                column: "SecondaryLanguageId",
                principalTable: "Language",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tourist_Language_PrimaryLanguageId",
                table: "Tourist",
                column: "PrimaryLanguageId",
                principalTable: "Language",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tourist_Language_SecondaryLanguageId",
                table: "Tourist",
                column: "SecondaryLanguageId",
                principalTable: "Language",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guide_Language_PrimaryLanguageId",
                table: "Guide");

            migrationBuilder.DropForeignKey(
                name: "FK_Guide_Language_SecondaryLanguageId",
                table: "Guide");

            migrationBuilder.DropForeignKey(
                name: "FK_Tourist_Language_PrimaryLanguageId",
                table: "Tourist");

            migrationBuilder.DropForeignKey(
                name: "FK_Tourist_Language_SecondaryLanguageId",
                table: "Tourist");

            migrationBuilder.DropIndex(
                name: "IX_Tourist_PrimaryLanguageId",
                table: "Tourist");

            migrationBuilder.DropIndex(
                name: "IX_Guide_PrimaryLanguageId",
                table: "Guide");

            migrationBuilder.DropIndex(
                name: "IX_Guide_SecondaryLanguageId",
                table: "Guide");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "User");

            migrationBuilder.DropColumn(
                name: "PrimaryLanguageId",
                table: "Tourist");

            migrationBuilder.DropColumn(
                name: "PrimaryLanguageId",
                table: "Guide");

            migrationBuilder.DropColumn(
                name: "SecondaryLanguageId",
                table: "Guide");

            migrationBuilder.RenameColumn(
                name: "SecondaryLanguageId",
                table: "Tourist",
                newName: "LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_Tourist_SecondaryLanguageId",
                table: "Tourist",
                newName: "IX_Tourist_LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tourist_Language_LanguageId",
                table: "Tourist",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
