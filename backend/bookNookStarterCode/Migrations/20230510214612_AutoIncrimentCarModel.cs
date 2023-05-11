using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace bookNookStarterCode.Migrations
{
    /// <inheritdoc />
    public partial class AutoIncrimentCarModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05302591-bc4c-4ce0-9963-e2d968f4670a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fb82933-c624-42dc-a824-3ce3a401707b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4875b938-fc7e-471c-99d2-8aee4e0ad117", null, "Admin", "ADMIN" },
                    { "80a2cf0c-7d97-4a3b-b1b2-e50e4b9301c4", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4875b938-fc7e-471c-99d2-8aee4e0ad117");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80a2cf0c-7d97-4a3b-b1b2-e50e4b9301c4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05302591-bc4c-4ce0-9963-e2d968f4670a", null, "Admin", "ADMIN" },
                    { "7fb82933-c624-42dc-a824-3ce3a401707b", null, "User", "USER" }
                });
        }
    }
}
