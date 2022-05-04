using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookWeb.Migrations
{
    public partial class oo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.RenameColumn(
            //    name: "UserName",
            //    table: "Guest",
            //    newName: "Phone");

            //migrationBuilder.RenameColumn(
            //    name: "Password",
            //    table: "Guest",
            //    newName: "Name");

            //migrationBuilder.AddColumn<bool>(
            //    name: "Deleted",
            //    table: "Guest",
            //    type: "bit",
            //    nullable: false,
            //    defaultValue: false);

            //migrationBuilder.AddColumn<string>(
            //    name: "Description",
            //    table: "Guest",
            //    type: "nvarchar(max)",
            //    nullable: true);

            //migrationBuilder.CreateTable(
            //    name: "Order",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        OrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Created = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Deleted = table.Column<bool>(type: "bit", nullable: false),
            //        TotalPrice = table.Column<double>(type: "float", nullable: false),
            //        PaidAmount = table.Column<double>(type: "float", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Order", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Role",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Deleted = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Role", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Status",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Deleted = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Status", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "User",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_User", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "OrderBook",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        OrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Created = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Deleted = table.Column<bool>(type: "bit", nullable: false),
            //        SalePrice = table.Column<double>(type: "float", nullable: false),
            //        BookId = table.Column<int>(type: "int", nullable: true),
            //        OrderId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_OrderBook", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_OrderBook_Book_BookId",
            //            column: x => x.BookId,
            //            principalTable: "Book",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_OrderBook_Order_OrderId",
            //            column: x => x.OrderId,
            //            principalTable: "Order",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_OrderBook_BookId",
            //    table: "OrderBook",
            //    column: "BookId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_OrderBook_OrderId",
            //    table: "OrderBook",
            //    column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        //    migrationBuilder.DropTable(
        //        name: "OrderBook");

        //    migrationBuilder.DropTable(
        //        name: "Role");

        //    migrationBuilder.DropTable(
        //        name: "Status");

        //    migrationBuilder.DropTable(
        //        name: "User");

        //    migrationBuilder.DropTable(
        //        name: "Order");

        //    migrationBuilder.DropColumn(
        //        name: "Deleted",
        //        table: "Guest");

        //    migrationBuilder.DropColumn(
        //        name: "Description",
        //        table: "Guest");

        //    migrationBuilder.RenameColumn(
        //        name: "Phone",
        //        table: "Guest",
        //        newName: "UserName");

        //    migrationBuilder.RenameColumn(
        //        name: "Name",
        //        table: "Guest",
        //        newName: "Password");
        }
    }
}
