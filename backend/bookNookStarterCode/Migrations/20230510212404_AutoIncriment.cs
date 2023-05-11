using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace bookNookStarterCode.Migrations
{
    /// <inheritdoc />
    public partial class AutoIncriment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d70eef5-2a6e-4076-a316-66a34d64a158");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2b106ac-ffe6-441c-98e9-1bd4cb0cff96");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05302591-bc4c-4ce0-9963-e2d968f4670a", null, "Admin", "ADMIN" },
                    { "7fb82933-c624-42dc-a824-3ce3a401707b", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "4d70eef5-2a6e-4076-a316-66a34d64a158", null, "User", "USER" },
                    { "c2b106ac-ffe6-441c-98e9-1bd4cb0cff96", null, "Admin", "ADMIN" }
                });
        }
    }
}
