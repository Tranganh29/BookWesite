using Microsoft.EntityFrameworkCore.Migrations;

namespace BookWeb.Migrations
{
    public partial class ppp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_User",
            //    table: "User");

            //migrationBuilder.RenameTable(
            //    name: "User",
            //    newName: "Guest");

            //migrationBuilder.AddColumn<bool>(
            //    name: "Delete",
            //    table: "Category",
            //    type: "bit",
            //    nullable: false,
            //    defaultValue: false);

            //migrationBuilder.AddColumn<int>(
            //    name: "CategoryId",
            //    table: "Book",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.AddColumn<bool>(
            //    name: "Deleted",
            //    table: "Book",
            //    type: "bit",
            //    nullable: false,
            //    defaultValue: false);

            //migrationBuilder.AddColumn<double>(
            //    name: "Discount",
            //    table: "Book",
            //    type: "float",
            //    nullable: false,
            //    defaultValue: 0.0);

            //migrationBuilder.AddColumn<double>(
            //    name: "Price",
            //    table: "Book",
            //    type: "float",
            //    nullable: false,
            //    defaultValue: 0.0);

            //migrationBuilder.AddColumn<int>(
            //    name: "Quantity",
            //    table: "Book",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Guest",
            //    table: "Guest",
            //    column: "Id");

            //migrationBuilder.CreateTable(
            //    name: "BookImg",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Deleted = table.Column<bool>(type: "bit", nullable: false),
            //        BookId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_BookImg", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_BookImg_Book_BookId",
            //            column: x => x.BookId,
            //            principalTable: "Book",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Book_CategoryId",
            //    table: "Book",
            //    column: "CategoryId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_BookImg_BookId",
            //    table: "BookImg",
            //    column: "BookId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Book_Category_CategoryId",
            //    table: "Book",
            //    column: "CategoryId",
            //    principalTable: "Category",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        //    migrationBuilder.DropForeignKey(
        //        name: "FK_Book_Category_CategoryId",
        //        table: "Book");

        //    migrationBuilder.DropTable(
        //        name: "BookImg");

        //    migrationBuilder.DropIndex(
        //        name: "IX_Book_CategoryId",
        //        table: "Book");

        //    migrationBuilder.DropPrimaryKey(
        //        name: "PK_Guest",
        //        table: "Guest");

        //    migrationBuilder.DropColumn(
        //        name: "Delete",
        //        table: "Category");

        //    migrationBuilder.DropColumn(
        //        name: "CategoryId",
        //        table: "Book");

        //    migrationBuilder.DropColumn(
        //        name: "Deleted",
        //        table: "Book");

        //    migrationBuilder.DropColumn(
        //        name: "Discount",
        //        table: "Book");

        //    migrationBuilder.DropColumn(
        //        name: "Price",
        //        table: "Book");

        //    migrationBuilder.DropColumn(
        //        name: "Quantity",
        //        table: "Book");

        //    migrationBuilder.RenameTable(
        //        name: "Guest",
        //        newName: "User");

        //    migrationBuilder.AddPrimaryKey(
        //        name: "PK_User",
        //        table: "User",
        //        column: "Id");
        }
    }
}
