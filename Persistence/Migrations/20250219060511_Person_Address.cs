using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Person_Address : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("159a8a45-b0dd-4ad5-bcb4-8fc37b542f9d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e43174b4-c6f8-4cca-9c0c-26aa87a7b88a"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 19, 6, 5, 10, 492, DateTimeKind.Utc).AddTicks(2029),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 19, 0, 27, 51, 171, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => new { x.PersonId, x.Id });
                    table.ForeignKey(
                        name: "FK_Address_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "RemoveTime", "Role", "UpdateTime", "Username" },
                values: new object[,]
                {
                    { new Guid("214336b3-1b1d-44aa-9dc1-b8767f747550"), "AQAAAAIAAYagAAAAEDRv1N/L2NLJIjaurd+jeh07F1gKBhi5EYqIDM3RD2ggDxwhl+9CxLKlXHNY2ryKBQ==", null, "role_admin", null, "admin" },
                    { new Guid("ca68932b-8c03-4ad2-8155-03a05bc05758"), "AQAAAAIAAYagAAAAEMd5cYWFf027GIN0PiRHyQiPQaCWR3BLUHZL13u7JpQA94qIIv+2Ii85X18E8VagAQ==", null, "role_user", null, "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("214336b3-1b1d-44aa-9dc1-b8767f747550"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca68932b-8c03-4ad2-8155-03a05bc05758"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 19, 0, 27, 51, 171, DateTimeKind.Local).AddTicks(5999),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 19, 6, 5, 10, 492, DateTimeKind.Utc).AddTicks(2029));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "RemoveTime", "Role", "UpdateTime", "Username" },
                values: new object[,]
                {
                    { new Guid("159a8a45-b0dd-4ad5-bcb4-8fc37b542f9d"), "AQAAAAIAAYagAAAAEAis+HeDjVqC7QAfX702TY0wFbHBBKk62aShB9OfIy/Ntfmb81LhTVE95ZhbqoRutg==", null, "role_admin", null, "admin" },
                    { new Guid("e43174b4-c6f8-4cca-9c0c-26aa87a7b88a"), "AQAAAAIAAYagAAAAEP0y4mWLZe0BrBUIq6W7d4U1UhvGY/DvYTKEHoKwJFgzWPsAwAJzddTr7Ca1Wbdqug==", null, "role_user", null, "user" }
                });
        }
    }
}
