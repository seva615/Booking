using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking.Data.Migrations
{
    public partial class editLether : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Cities_CityEntityId",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_CityEntityId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "CityEntityId",
                table: "Hotels");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_CityId",
                table: "Hotels",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Cities_CityId",
                table: "Hotels",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Cities_CityId",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_CityId",
                table: "Hotels");

            migrationBuilder.AddColumn<Guid>(
                name: "CityEntityId",
                table: "Hotels",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_CityEntityId",
                table: "Hotels",
                column: "CityEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Cities_CityEntityId",
                table: "Hotels",
                column: "CityEntityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
