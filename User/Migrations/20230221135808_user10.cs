using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace User.Migrations
{
    /// <inheritdoc />
    public partial class user10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "251d81e6-0c8d-428a-8686-8e5452a11625");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73c8c9e7-2ac9-46a5-9217-50b8d264f795");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d8d3c8c-2d35-42a3-8f24-8a1f35826a18");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33aad42b-6d80-495e-a574-9c33e0c2afe5", "5ccf6b24-2769-4e72-b94c-560f9b02dda4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33aad42b-6d80-495e-a574-9c33e0c2afe5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ccf6b24-2769-4e72-b94c-560f9b02dda4");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "251d81e6-0c8d-428a-8686-8e5452a11625", null, "Etudiant", "Etudiant" },
                    { "33aad42b-6d80-495e-a574-9c33e0c2afe5", null, "admin", "Admin" },
                    { "73c8c9e7-2ac9-46a5-9217-50b8d264f795", null, "Employé", "Employé" },
                    { "7d8d3c8c-2d35-42a3-8f24-8a1f35826a18", null, "Enseignant", "Enseignant" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5ccf6b24-2769-4e72-b94c-560f9b02dda4", 0, "9ae896ab-b190-4fbd-ad71-20194dbb9249", "admin@admin.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEJ28/1IL076Ka5F+EfGnZTKNNEfB6SG15NJHetr3gJDiGWUwWEJKZrOSlPI3LqQRjg==", null, false, "de4445b0-ec08-48f4-9a67-d736d4129fdf", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "33aad42b-6d80-495e-a574-9c33e0c2afe5", "5ccf6b24-2769-4e72-b94c-560f9b02dda4" });
        }
    }
}
