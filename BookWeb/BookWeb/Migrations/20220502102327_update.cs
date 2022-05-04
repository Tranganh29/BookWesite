using Microsoft.EntityFrameworkCore.Migrations;

namespace BookWeb.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<int>(
            //    name: "CreatedUserId",
            //    table: "Book",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.AddColumn<int>(
            //    name: "UpdateUserId",
            //    table: "Book",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Book_CreatedUserId",
            //    table: "Book",
            //    column: "CreatedUserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Book_UpdateUserId",
            //    table: "Book",
            //    column: "UpdateUserId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Book_User_CreatedUserId",
            //    table: "Book",
            //    column: "CreatedUserId",
            //    principalTable: "User",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Book_User_UpdateUserId",
            //    table: "Book",
            //    column: "UpdateUserId",
            //    principalTable: "User",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Book_User_CreatedUserId",
            //    table: "Book");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Book_User_UpdateUserId",
            //    table: "Book");

            //migrationBuilder.DropIndex(
            //    name: "IX_Book_CreatedUserId",
            //    table: "Book");

            //migrationBuilder.DropIndex(
            //    name: "IX_Book_UpdateUserId",
            //    table: "Book");

            //migrationBuilder.DropColumn(
            //    name: "CreatedUserId",
            //    table: "Book");

            //migrationBuilder.DropColumn(
            //    name: "UpdateUserId",
            //    table: "Book");
        }
    }
}
