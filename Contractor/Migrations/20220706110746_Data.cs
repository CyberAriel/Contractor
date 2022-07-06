using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contractor.Migrations
{
    public partial class Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contractors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Nip = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<bool>(type: "bit", nullable: false),
                    Desctiption = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Activ = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contractors", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contractors");
        }
    }
}
