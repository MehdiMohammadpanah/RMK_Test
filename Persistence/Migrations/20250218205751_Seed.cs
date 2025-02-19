using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RemovedTime",
                table: "Users",
                newName: "RemoveTime");

            migrationBuilder.AlterColumn<bool>(
                name: "IsRemoved",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 19, 0, 27, 51, 171, DateTimeKind.Local).AddTicks(5999),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "RemoveTime", "Role", "UpdateTime", "Username" },
                values: new object[,]
                {
                    { new Guid("159a8a45-b0dd-4ad5-bcb4-8fc37b542f9d"), "AQAAAAIAAYagAAAAEAis+HeDjVqC7QAfX702TY0wFbHBBKk62aShB9OfIy/Ntfmb81LhTVE95ZhbqoRutg==", null, "role_admin", null, "admin" },
                    { new Guid("e43174b4-c6f8-4cca-9c0c-26aa87a7b88a"), "AQAAAAIAAYagAAAAEP0y4mWLZe0BrBUIq6W7d4U1UhvGY/DvYTKEHoKwJFgzWPsAwAJzddTr7Ca1Wbdqug==", null, "role_user", null, "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("159a8a45-b0dd-4ad5-bcb4-8fc37b542f9d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e43174b4-c6f8-4cca-9c0c-26aa87a7b88a"));

            migrationBuilder.RenameColumn(
                name: "RemoveTime",
                table: "Users",
                newName: "RemovedTime");

            migrationBuilder.AlterColumn<bool>(
                name: "IsRemoved",
                table: "Users",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 19, 0, 27, 51, 171, DateTimeKind.Local).AddTicks(5999));
        }
    }
}
