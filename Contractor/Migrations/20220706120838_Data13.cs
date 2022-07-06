using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contractor.Migrations
{
    public partial class Data13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TypeContractor",
                table: "Contractors",
                newName: "TypCon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TypCon",
                table: "Contractors",
                newName: "TypeContractor");
        }
    }
}
