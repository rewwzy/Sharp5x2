using Microsoft.EntityFrameworkCore.Migrations;

namespace CSharp5Lap45.Data.Migrations
{
    public partial class FPTPOLYCHSARP5DH : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FClass",
                columns: table => new
                {
                    IdClass = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameClass = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FClass", x => x.IdClass);
                });

            migrationBuilder.CreateTable(
                name: "FStudent",
                columns: table => new
                {
                    StId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mark = table.Column<float>(type: "real", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdClass = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FStudent", x => x.StId);
                    table.ForeignKey(
                        name: "FK_FStudent_FClass_IdClass",
                        column: x => x.IdClass,
                        principalTable: "FClass",
                        principalColumn: "IdClass",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FClass",
                columns: new[] { "IdClass", "NameClass" },
                values: new object[] { 1, "Lop 1" });

            migrationBuilder.InsertData(
                table: "FClass",
                columns: new[] { "IdClass", "NameClass" },
                values: new object[] { 2, "Lop 2" });

            migrationBuilder.InsertData(
                table: "FClass",
                columns: new[] { "IdClass", "NameClass" },
                values: new object[] { 3, "Lop 3" });

            migrationBuilder.InsertData(
                table: "FStudent",
                columns: new[] { "StId", "Email", "IdClass", "Mark", "Name" },
                values: new object[,]
                {
                    { 1, "st1@gmail.com", 1, 5f, "Dungna1" },
                    { 4, "st4@gmail.com", 1, 10f, "Dungna4" },
                    { 2, "st2@gmail.com", 2, 7f, "Dungna2" },
                    { 3, "st3@gmail.com", 3, 2f, "Dungna3" },
                    { 5, "SV5@gmail.com", 3, 8f, "Dungna5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FStudent_IdClass",
                table: "FStudent",
                column: "IdClass");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FStudent");

            migrationBuilder.DropTable(
                name: "FClass");
        }
    }
}
