﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace BookWeb.Migrations
{
    public partial class mapper : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<bool>(
            //    name: "Deleted",
            //    table: "User",
            //    type: "bit",
            //    nullable: false,
            //    defaultValue: false);

            //migrationBuilder.AddColumn<int>(
            //    name: "RoleId",
            //    table: "User",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_User_RoleId",
            //    table: "User",
            //    column: "RoleId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_User_Role_RoleId",
            //    table: "User",
            //    column: "RoleId",
            //    principalTable: "Role",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
       {
        //    migrationBuilder.DropForeignKey(
        //        name: "FK_User_Role_RoleId",
        //        table: "User");

        //    migrationBuilder.DropIndex(
        //        name: "IX_User_RoleId",
        //        table: "User");

        //    migrationBuilder.DropColumn(
        //        name: "Deleted",
        //        table: "User");

        //    migrationBuilder.DropColumn(
        //        name: "RoleId",
        //        table: "User");
        }
    }
}
