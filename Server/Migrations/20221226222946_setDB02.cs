using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Server.Migrations
{
    public partial class setDB02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Resevations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Resevations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TravalCompanyId",
                table: "Resevations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ResevationId",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Resevations_CustomerId",
                table: "Resevations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Resevations_RoomId",
                table: "Resevations",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Resevations_TravalCompanyId",
                table: "Resevations",
                column: "TravalCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ResevationId",
                table: "Payments",
                column: "ResevationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Resevations_ResevationId",
                table: "Payments",
                column: "ResevationId",
                principalTable: "Resevations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resevations_Customers_CustomerId",
                table: "Resevations",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resevations_Rooms_RoomId",
                table: "Resevations",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resevations_TravalCompanies_TravalCompanyId",
                table: "Resevations",
                column: "TravalCompanyId",
                principalTable: "TravalCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Resevations_ResevationId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Resevations_Customers_CustomerId",
                table: "Resevations");

            migrationBuilder.DropForeignKey(
                name: "FK_Resevations_Rooms_RoomId",
                table: "Resevations");

            migrationBuilder.DropForeignKey(
                name: "FK_Resevations_TravalCompanies_TravalCompanyId",
                table: "Resevations");

            migrationBuilder.DropIndex(
                name: "IX_Resevations_CustomerId",
                table: "Resevations");

            migrationBuilder.DropIndex(
                name: "IX_Resevations_RoomId",
                table: "Resevations");

            migrationBuilder.DropIndex(
                name: "IX_Resevations_TravalCompanyId",
                table: "Resevations");

            migrationBuilder.DropIndex(
                name: "IX_Payments_ResevationId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Resevations");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Resevations");

            migrationBuilder.DropColumn(
                name: "TravalCompanyId",
                table: "Resevations");

            migrationBuilder.DropColumn(
                name: "ResevationId",
                table: "Payments");
        }
    }
}
