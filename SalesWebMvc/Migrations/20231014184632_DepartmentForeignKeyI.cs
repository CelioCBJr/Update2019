using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class DepartmentForeignKeyI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Departament_DepartamentId",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Seller");

            migrationBuilder.AlterColumn<int>(
                name: "DepartamentId",
                table: "Seller",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Departament_DepartamentId",
                table: "Seller",
                column: "DepartamentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Departament_DepartamentId",
                table: "Seller");

            migrationBuilder.AlterColumn<int>(
                name: "DepartamentId",
                table: "Seller",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Seller",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Departament_DepartamentId",
                table: "Seller",
                column: "DepartamentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
