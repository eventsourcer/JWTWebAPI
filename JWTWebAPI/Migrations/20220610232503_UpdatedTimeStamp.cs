using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JWTWebAPI.Migrations
{
    public partial class UpdatedTimeStamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("08cffbc5-14a5-474e-b7b1-38cfd83db3fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4026226-348a-4950-be73-377f2c6161d6"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "UpdatedTimeStamp",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedTimeStamp", "Password", "Username" },
                values: new object[] { new Guid("c4026226-348a-4950-be73-377f2c6161d6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sarwan", "sarwan" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedTimeStamp", "Password", "Username" },
                values: new object[] { new Guid("08cffbc5-14a5-474e-b7b1-38cfd83db3fd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "postgres", "postgres" });
        }
    }
}
