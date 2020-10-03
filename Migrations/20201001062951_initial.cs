using Microsoft.EntityFrameworkCore.Migrations;

namespace DockerAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Summaries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summaries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Summaries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Freezing" });

            migrationBuilder.InsertData(
                table: "Summaries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Bracing" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Summaries");
        }
    }
}
