using Microsoft.EntityFrameworkCore.Migrations;

namespace BoarderApp.Migrations
{
    public partial class AddedUnitFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Unit",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

       

            migrationBuilder.AddColumn<string>(
               name: "UnitName",
               table: "Customers",
               type: "nvarchar(max)",
               nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UnitID",
                table: "Customers",
                column: "UnitID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Units_UnitID",
                table: "Customers",
                column: "UnitID",
                principalTable: "Units",
                principalColumn: "UnitID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Units_UnitID",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_UnitID",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "UnitID",
                table: "Customers");
        }
    }
}
