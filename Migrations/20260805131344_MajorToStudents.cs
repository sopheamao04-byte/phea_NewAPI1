using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace phea_NewAPI1.Migrations
{
    /// <inheritdoc />
    public partial class MajorToStudents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MajorId",
                table: "tbl_Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "tbl_Majors",
                columns: table => new
                {
                    MajorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MajorName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Majors", x => x.MajorId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Students_MajorId",
                table: "tbl_Students",
                column: "MajorId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Students_tbl_Majors_MajorId",
                table: "tbl_Students",
                column: "MajorId",
                principalTable: "tbl_Majors",
                principalColumn: "MajorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Students_tbl_Majors_MajorId",
                table: "tbl_Students");

            migrationBuilder.DropTable(
                name: "tbl_Majors");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Students_MajorId",
                table: "tbl_Students");

            migrationBuilder.DropColumn(
                name: "MajorId",
                table: "tbl_Students");
        }
    }
}
