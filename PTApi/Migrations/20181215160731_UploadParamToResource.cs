using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PTApi.Migrations
{
    public partial class UploadParamToResource : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageCaption",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Resources",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageCaption",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Resources");
        }
    }
}
