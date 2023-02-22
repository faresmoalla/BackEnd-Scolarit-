using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace User.Migrations
{
    /// <inheritdoc />
    public partial class user13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "106b5844-bdd7-4fdb-aef1-e6a5e5213d84");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7cf7a602-a4b0-4531-ae30-3e5867c4cea1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9841a92d-4f6d-4b47-9a75-f9e60437ffbb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b7d7f956-2695-4709-824a-ac13c696dc5d", "7a4bc5f0-5b6e-4778-a6c7-cf4d9259e1fb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7d7f956-2695-4709-824a-ac13c696dc5d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a4bc5f0-5b6e-4778-a6c7-cf4d9259e1fb");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "106b5844-bdd7-4fdb-aef1-e6a5e5213d84", null, "Enseignant", "Enseignant" },
                    { "7cf7a602-a4b0-4531-ae30-3e5867c4cea1", null, "Etudiant", "Etudiant" },
                    { "9841a92d-4f6d-4b47-9a75-f9e60437ffbb", null, "Employé", "Employé" },
                    { "b7d7f956-2695-4709-824a-ac13c696dc5d", null, "admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7a4bc5f0-5b6e-4778-a6c7-cf4d9259e1fb", 0, "d92f666b-ac72-4991-8f56-465ca23a959c", "admin@admin.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEIujV5aAG0q8gqedDP9FjUyZHdTQ/QQ6aPjHkDWFrbsI8fk75GGtQESW3qCU8mdGGA==", null, false, "70a3071c-5bb2-4eb6-a761-66f50952b4d6", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b7d7f956-2695-4709-824a-ac13c696dc5d", "7a4bc5f0-5b6e-4778-a6c7-cf4d9259e1fb" });
        }
    }
}
