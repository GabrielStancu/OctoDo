using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OctoDo.Server.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TrackingAndActivityFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Enabled",
                table: "User",
                newName: "Disabled");

            migrationBuilder.RenameColumn(
                name: "Enabled",
                table: "Routine",
                newName: "Disabled");

            migrationBuilder.RenameColumn(
                name: "Enabled",
                table: "Activity",
                newName: "Disabled");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Routine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Routine",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Routine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Activity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DurationHours",
                table: "Activity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DurationMinutes",
                table: "Activity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DurationSeconds",
                table: "Activity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ScheduledHour",
                table: "Activity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ScheduledMinute",
                table: "Activity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Activity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Routine");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Routine");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Routine");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Activity");

            migrationBuilder.DropColumn(
                name: "DurationHours",
                table: "Activity");

            migrationBuilder.DropColumn(
                name: "DurationMinutes",
                table: "Activity");

            migrationBuilder.DropColumn(
                name: "DurationSeconds",
                table: "Activity");

            migrationBuilder.DropColumn(
                name: "ScheduledHour",
                table: "Activity");

            migrationBuilder.DropColumn(
                name: "ScheduledMinute",
                table: "Activity");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Activity");

            migrationBuilder.RenameColumn(
                name: "Disabled",
                table: "User",
                newName: "Enabled");

            migrationBuilder.RenameColumn(
                name: "Disabled",
                table: "Routine",
                newName: "Enabled");

            migrationBuilder.RenameColumn(
                name: "Disabled",
                table: "Activity",
                newName: "Enabled");
        }
    }
}
