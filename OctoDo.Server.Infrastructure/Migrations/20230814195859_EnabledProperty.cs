using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OctoDo.Server.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EnabledProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Enabled",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Enabled",
                table: "Routine",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Enabled",
                table: "Activity",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Enabled",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Enabled",
                table: "Routine");

            migrationBuilder.DropColumn(
                name: "Enabled",
                table: "Activity");
        }
    }
}
