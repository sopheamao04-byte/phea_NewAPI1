using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace phea_NewAPI1.Migrations
{
    /// <inheritdoc />
    public partial class DepartmentToStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "tbl_Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Students_DepartmentId",
                table: "tbl_Students",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Students_Departments_DepartmentId",
                table: "tbl_Students",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Students_Departments_DepartmentId",
                table: "tbl_Students");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Students_DepartmentId",
                table: "tbl_Students");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "tbl_Students");
        }
    }
}
