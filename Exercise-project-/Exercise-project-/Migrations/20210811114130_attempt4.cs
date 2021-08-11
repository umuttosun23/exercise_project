using Microsoft.EntityFrameworkCore.Migrations;

namespace Exercise_project_.Migrations
{
    public partial class attempt4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CategoryStatus",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryStatus",
                table: "Categories");
        }
    }
}
