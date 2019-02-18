using Microsoft.EntityFrameworkCore.Migrations;

namespace travelmos.Migrations
{
    public partial class nullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guide_Offer_OfferId",
                table: "Guide");

            migrationBuilder.DropForeignKey(
                name: "FK_Guide_Language_SecondaryLanguageId",
                table: "Guide");

            migrationBuilder.DropForeignKey(
                name: "FK_Tourist_Language_SecondaryLanguageId",
                table: "Tourist");

            migrationBuilder.AlterColumn<int>(
                name: "SecondaryLanguageId",
                table: "Tourist",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SecondaryLanguageId",
                table: "Guide",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "OfferId",
                table: "Guide",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Guide_Offer_OfferId",
                table: "Guide",
                column: "OfferId",
                principalTable: "Offer",
                principalColumn: "OfferId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Guide_Language_SecondaryLanguageId",
                table: "Guide",
                column: "SecondaryLanguageId",
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
                name: "FK_Guide_Offer_OfferId",
                table: "Guide");

            migrationBuilder.DropForeignKey(
                name: "FK_Guide_Language_SecondaryLanguageId",
                table: "Guide");

            migrationBuilder.DropForeignKey(
                name: "FK_Tourist_Language_SecondaryLanguageId",
                table: "Tourist");

            migrationBuilder.AlterColumn<int>(
                name: "SecondaryLanguageId",
                table: "Tourist",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SecondaryLanguageId",
                table: "Guide",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OfferId",
                table: "Guide",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Guide_Offer_OfferId",
                table: "Guide",
                column: "OfferId",
                principalTable: "Offer",
                principalColumn: "OfferId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Guide_Language_SecondaryLanguageId",
                table: "Guide",
                column: "SecondaryLanguageId",
                principalTable: "Language",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tourist_Language_SecondaryLanguageId",
                table: "Tourist",
                column: "SecondaryLanguageId",
                principalTable: "Language",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
