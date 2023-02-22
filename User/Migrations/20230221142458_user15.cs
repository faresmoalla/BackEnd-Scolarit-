using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace User.Migrations
{
    /// <inheritdoc />
    public partial class user15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2910e9c0-348a-41ac-9d68-955392d0fb9f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db5f1d3d-939f-40d1-892b-8ac654afc399");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfd6b226-5c39-4c64-9149-83bbe32a2f28");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5520f0fc-c44e-43a8-89b0-ecf7376469c7", "1406df4a-b2fc-4781-87d0-b71a0920ae68" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5520f0fc-c44e-43a8-89b0-ecf7376469c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1406df4a-b2fc-4781-87d0-b71a0920ae68");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1315ee7e-9d89-4256-b8d8-7be5a3a9fd28", null, "admin", "Admin" },
                    { "1a9624ce-116c-4c1f-8e94-74dd476c7058", null, "Enseignant", "Enseignant" },
                    { "bcdd6348-b42c-4eab-8fce-37b642761754", null, "Employé", "Employé" },
                    { "f0869c98-9aa1-4e39-87d0-7a85a1a5192f", null, "Etudiant", "Etudiant" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ed256738-27bc-4cf1-8282-3b69fc8d2b7f", 0, "73565897-1ee6-41d8-b973-d82d40724733", "admin@admin.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEJivTwxKKYUVX4M67yVeMgjiaLaDIzvvS0oqBE3CfNk5o5oLdz+Za8b4v5j4YO0BGA==", null, false, "21eb0c9b-99a8-4b31-a82a-f159676f2b3d", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1315ee7e-9d89-4256-b8d8-7be5a3a9fd28", "ed256738-27bc-4cf1-8282-3b69fc8d2b7f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a9624ce-116c-4c1f-8e94-74dd476c7058");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcdd6348-b42c-4eab-8fce-37b642761754");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0869c98-9aa1-4e39-87d0-7a85a1a5192f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1315ee7e-9d89-4256-b8d8-7be5a3a9fd28", "ed256738-27bc-4cf1-8282-3b69fc8d2b7f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1315ee7e-9d89-4256-b8d8-7be5a3a9fd28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed256738-27bc-4cf1-8282-3b69fc8d2b7f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2910e9c0-348a-41ac-9d68-955392d0fb9f", null, "Enseignant", "Enseignant" },
                    { "5520f0fc-c44e-43a8-89b0-ecf7376469c7", null, "admin", "Admin" },
                    { "db5f1d3d-939f-40d1-892b-8ac654afc399", null, "Employé", "Employé" },
                    { "dfd6b226-5c39-4c64-9149-83bbe32a2f28", null, "Etudiant", "Etudiant" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1406df4a-b2fc-4781-87d0-b71a0920ae68", 0, "4c0bc072-9e29-4748-bd66-3ad23de4f332", "admin@admin.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEA4dnjlXpSFrqd2wlpufjlCtnIZRWDO+FPFn/adrDto+o9bq30CYlEpqLslK/KMCTA==", null, false, "491415a0-b0e8-4f00-828f-638fa6d5e0ca", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5520f0fc-c44e-43a8-89b0-ecf7376469c7", "1406df4a-b2fc-4781-87d0-b71a0920ae68" });
        }
    }
}
