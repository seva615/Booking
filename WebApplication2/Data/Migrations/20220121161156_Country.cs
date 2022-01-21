using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking.Data.Migrations
{
    public partial class Country : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Contries_ContryEntityId",
                table: "Cities");

            migrationBuilder.DropTable(
                name: "Contries");

            migrationBuilder.DropIndex(
                name: "IX_Cities_ContryEntityId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "AdvantageId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "ContryEntityId",
                table: "Cities");

            migrationBuilder.RenameColumn(
                name: "ContryId",
                table: "Cities",
                newName: "CountryId");

            migrationBuilder.AddColumn<Guid>(
                name: "RoomEntityId1",
                table: "Advantages",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CountryName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Advantages_RoomEntityId1",
                table: "Advantages",
                column: "RoomEntityId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Advantages_Rooms_RoomEntityId1",
                table: "Advantages",
                column: "RoomEntityId1",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advantages_Rooms_RoomEntityId1",
                table: "Advantages");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Cities_CountryId",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Advantages_RoomEntityId1",
                table: "Advantages");

            migrationBuilder.DropColumn(
                name: "RoomEntityId1",
                table: "Advantages");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "Cities",
                newName: "ContryId");

            migrationBuilder.AddColumn<Guid>(
                name: "AdvantageId",
                table: "Rooms",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ContryEntityId",
                table: "Cities",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Contries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ContryName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contries", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_ContryEntityId",
                table: "Cities",
                column: "ContryEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Contries_ContryEntityId",
                table: "Cities",
                column: "ContryEntityId",
                principalTable: "Contries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
