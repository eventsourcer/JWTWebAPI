using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JWTWebAPI.Migrations
{
    public partial class UpdateCreateddTimeStampRemove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("863dc3b3-b9a0-4d69-b2b6-53d0a0cc344c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4b35ea3-b852-47b7-8180-9b18be3bee90"));

            migrationBuilder.DropColumn(
                name: "CreatedTimeStamp",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdatedTimeStamp",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { new Guid("d5b4c19d-464d-4218-b5c8-983f7a07e787"), "sarwan", "sarwan" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { new Guid("eaca7f87-9964-453d-af83-05733ef032b9"), "postgres", "postgres" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5b4c19d-464d-4218-b5c8-983f7a07e787"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eaca7f87-9964-453d-af83-05733ef032b9"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTimeStamp",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTimeStamp",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedTimeStamp", "Password", "UpdatedTimeStamp", "Username" },
                values: new object[] { new Guid("863dc3b3-b9a0-4d69-b2b6-53d0a0cc344c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sarwan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sarwan" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedTimeStamp", "Password", "UpdatedTimeStamp", "Username" },
                values: new object[] { new Guid("e4b35ea3-b852-47b7-8180-9b18be3bee90"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "postgres", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "postgres" });
        }
    }
}
