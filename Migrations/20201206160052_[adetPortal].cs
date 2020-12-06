using Microsoft.EntityFrameworkCore.Migrations;

namespace adetmidtermq2jintalanmikaela.Migrations
{
    public partial class adetPortal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentPortal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentNumber = table.Column<string>(nullable: true),
                    StudentName = table.Column<string>(nullable: true),
                    PQ1 = table.Column<double>(nullable: false),
                    PQ2 = table.Column<double>(nullable: false),
                    PQ3 = table.Column<double>(nullable: false),
                    PA1 = table.Column<double>(nullable: false),
                    PA2 = table.Column<double>(nullable: false),
                    PA3 = table.Column<double>(nullable: false),
                    PCG = table.Column<double>(nullable: false),
                    MQ1 = table.Column<double>(nullable: false),
                    MQ2 = table.Column<double>(nullable: false),
                    MQ3 = table.Column<double>(nullable: false),
                    MA1 = table.Column<double>(nullable: false),
                    MA2 = table.Column<double>(nullable: false),
                    MA3 = table.Column<double>(nullable: false),
                    MCG = table.Column<double>(nullable: false),
                    PFQ1 = table.Column<double>(nullable: false),
                    PFQ2 = table.Column<double>(nullable: false),
                    PFQ3 = table.Column<double>(nullable: false),
                    PFA1 = table.Column<double>(nullable: false),
                    PFA2 = table.Column<double>(nullable: false),
                    PFA3 = table.Column<double>(nullable: false),
                    PFCG = table.Column<double>(nullable: false),
                    FQ1 = table.Column<double>(nullable: false),
                    FQ2 = table.Column<double>(nullable: false),
                    FQ3 = table.Column<double>(nullable: false),
                    FA1 = table.Column<double>(nullable: false),
                    FA2 = table.Column<double>(nullable: false),
                    FA3 = table.Column<double>(nullable: false),
                    FCG = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentPortal", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentPortal");
        }
    }
}
