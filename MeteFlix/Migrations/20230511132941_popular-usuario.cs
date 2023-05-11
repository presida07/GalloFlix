using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeteFlix.Migrations
{
    public partial class popularusuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c0942b5-6184-43cc-8216-eeaa9e92c39e", "564dd811-d2f0-4c89-b951-d3050b48b3a0", "Moderador", "MODERADOR" },
                    { "7a9b5546-007f-47a9-a646-cb35344bd6cd", "9c2306c7-fbbf-4c22-8f7c-bc5a5e473be9", "Administrador", "ADMINISTRADOR" },
                    { "c486a401-47f5-4ad5-873b-2b3c2d320f6f", "92e7d836-3419-4408-9d3f-ef0f1bc32626", "Usuário", "USUÁRIO" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "611bbaad-d68e-406b-a97b-c52950f07ec8", 0, "a4a70c99-d413-4087-8db1-003e55de1ddd", new DateTime(1981, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AppUser", "gallojunior@gmail.com", true, false, null, "José Antonio Gallo Junior", "GALLOJUNIOR@GMAIL.COM", "GALLOJUNIOR", "AQAAAAEAACcQAAAAEPQMQwyrAdCN/fwMd4qaZDklODFSDE2XSEBooyMc8P0V4ydiwlYN/bAaCKaNuM6XxQ==", "14981544857", true, "/img/users/avatar.png", "65c79990-bdb6-4b31-b7df-4e6ab44c78c1", false, "GalloJunior" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7a9b5546-007f-47a9-a646-cb35344bd6cd", "611bbaad-d68e-406b-a97b-c52950f07ec8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2c0942b5-6184-43cc-8216-eeaa9e92c39e");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c486a401-47f5-4ad5-873b-2b3c2d320f6f");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7a9b5546-007f-47a9-a646-cb35344bd6cd", "611bbaad-d68e-406b-a97b-c52950f07ec8" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "7a9b5546-007f-47a9-a646-cb35344bd6cd");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "611bbaad-d68e-406b-a97b-c52950f07ec8");
        }
    }
}
