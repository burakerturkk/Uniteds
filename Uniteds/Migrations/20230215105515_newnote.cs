using Microsoft.EntityFrameworkCore.Migrations;

namespace Uniteds.Migrations
{
    public partial class newnote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Notes_ParentId",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Notes_ParentId",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Notes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Notes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notes_ParentId",
                table: "Notes",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Notes_ParentId",
                table: "Notes",
                column: "ParentId",
                principalTable: "Notes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
