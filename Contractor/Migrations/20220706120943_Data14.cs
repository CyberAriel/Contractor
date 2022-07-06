using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contractor.Migrations
{
    public partial class Data14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TypCon",
                table: "Contractors",
                newName: "TypContractor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TypContractor",
                table: "Contractors",
                newName: "TypCon");
        }
    }
}
