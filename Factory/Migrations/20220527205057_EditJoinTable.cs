using Microsoft.EntityFrameworkCore.Migrations;

namespace Registrar.Migrations
{
    public partial class EditJoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PassFail",
                table: "MachineEngineer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PassFail",
                table: "MachineEngineer",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
