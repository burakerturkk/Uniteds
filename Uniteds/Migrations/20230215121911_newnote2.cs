using Microsoft.EntityFrameworkCore.Migrations;

namespace Uniteds.Migrations
{
    public partial class newnote2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SubNotes_NoteId",
                table: "SubNotes",
                column: "NoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubNotes_Notes_NoteId",
                table: "SubNotes",
                column: "NoteId",
                principalTable: "Notes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubNotes_Notes_NoteId",
                table: "SubNotes");

            migrationBuilder.DropIndex(
                name: "IX_SubNotes_NoteId",
                table: "SubNotes");
        }
    }
}
