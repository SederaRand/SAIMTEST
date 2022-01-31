using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class correctionCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCustomers",
                table: "Company");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdCustomers",
                table: "Company",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
