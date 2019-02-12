using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace travelmos.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    LanguageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.LanguageId);
                });

            migrationBuilder.CreateTable(
                name: "Offer",
                columns: table => new
                {
                    OfferId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    FromTime = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    IncludedTransport = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Seats = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offer", x => x.OfferId);
                });

            migrationBuilder.CreateTable(
                name: "Tourist",
                columns: table => new
                {
                    TouristId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tourist", x => x.TouristId);
                    table.ForeignKey(
                        name: "FK_Tourist_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Guide",
                columns: table => new
                {
                    GuideId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    OfferId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guide", x => x.GuideId);
                    table.ForeignKey(
                        name: "FK_Guide_Offer_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offer",
                        principalColumn: "OfferId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    BookingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OfferId = table.Column<int>(nullable: false),
                    TouristId = table.Column<int>(nullable: false),
                    ReservedSeats = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_Booking_Offer_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offer",
                        principalColumn: "OfferId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booking_Tourist_TouristId",
                        column: x => x.TouristId,
                        principalTable: "Tourist",
                        principalColumn: "TouristId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserUserType",
                columns: table => new
                {
                    UserUserTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GuideId = table.Column<int>(nullable: false),
                    TouristId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserUserType", x => x.UserUserTypeId);
                    table.ForeignKey(
                        name: "FK_UserUserType_Guide_GuideId",
                        column: x => x.GuideId,
                        principalTable: "Guide",
                        principalColumn: "GuideId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserUserType_Tourist_TouristId",
                        column: x => x.TouristId,
                        principalTable: "Tourist",
                        principalColumn: "TouristId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserUserTypeId = table.Column<int>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_UserUserType_UserUserTypeId",
                        column: x => x.UserUserTypeId,
                        principalTable: "UserUserType",
                        principalColumn: "UserUserTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_OfferId",
                table: "Booking",
                column: "OfferId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_TouristId",
                table: "Booking",
                column: "TouristId");

            migrationBuilder.CreateIndex(
                name: "IX_Guide_OfferId",
                table: "Guide",
                column: "OfferId");

            migrationBuilder.CreateIndex(
                name: "IX_Tourist_LanguageId",
                table: "Tourist",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserUserTypeId",
                table: "User",
                column: "UserUserTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserUserType_GuideId",
                table: "UserUserType",
                column: "GuideId");

            migrationBuilder.CreateIndex(
                name: "IX_UserUserType_TouristId",
                table: "UserUserType",
                column: "TouristId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserUserType");

            migrationBuilder.DropTable(
                name: "Guide");

            migrationBuilder.DropTable(
                name: "Tourist");

            migrationBuilder.DropTable(
                name: "Offer");

            migrationBuilder.DropTable(
                name: "Language");
        }
    }
}
