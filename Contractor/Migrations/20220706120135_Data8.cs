using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contractor.Migrations
{
    public partial class Data8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentGender",
                table: "Contractors",
                newName: "TypeContractor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TypeContractor",
                table: "Contractors",
                newName: "StudentGender");
        }
    }
}
