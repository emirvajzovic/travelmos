using Microsoft.EntityFrameworkCore.Migrations;

namespace travelmos.Migrations
{
    public partial class allowNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserUserType_Guide_GuideId",
                table: "UserUserType");

            migrationBuilder.DropForeignKey(
                name: "FK_UserUserType_Tourist_TouristId",
                table: "UserUserType");

            migrationBuilder.AlterColumn<int>(
                name: "TouristId",
                table: "UserUserType",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "GuideId",
                table: "UserUserType",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_UserUserType_Guide_GuideId",
                table: "UserUserType",
                column: "GuideId",
                principalTable: "Guide",
                principalColumn: "GuideId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserUserType_Tourist_TouristId",
                table: "UserUserType",
                column: "TouristId",
                principalTable: "Tourist",
                principalColumn: "TouristId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserUserType_Guide_GuideId",
                table: "UserUserType");

            migrationBuilder.DropForeignKey(
                name: "FK_UserUserType_Tourist_TouristId",
                table: "UserUserType");

            migrationBuilder.AlterColumn<int>(
                name: "TouristId",
                table: "UserUserType",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GuideId",
                table: "UserUserType",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserUserType_Guide_GuideId",
                table: "UserUserType",
                column: "GuideId",
                principalTable: "Guide",
                principalColumn: "GuideId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserUserType_Tourist_TouristId",
                table: "UserUserType",
                column: "TouristId",
                principalTable: "Tourist",
                principalColumn: "TouristId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
