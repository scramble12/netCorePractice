using Microsoft.EntityFrameworkCore.Migrations;

namespace HattrickMVC.Migrations
{
    public partial class addNogometToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nogomet",
                columns: table => new
                {
                    SportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SportName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EkipaDomacin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EkipaGost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bet1 = table.Column<float>(type: "real", nullable: false),
                    bet2 = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nogomet", x => x.SportId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nogomet");
        }
    }
}
