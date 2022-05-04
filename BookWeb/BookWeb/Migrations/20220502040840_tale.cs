using Microsoft.EntityFrameworkCore.Migrations;

namespace BookWeb.Migrations
{
    public partial class tale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        //    migrationBuilder.CreateTable(
        //        name: "Book",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            NameBook = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Book", x => x.Id);
        //        });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Book");
        }
    }
}
