using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JWTWebAPI.Migrations
{
    public partial class CreatedTimeStamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41a3e297-4e6b-4c81-8fe1-c55d8bdd025b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("642e8931-043e-4c1e-b2ba-b128160593f7"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTimeStamp",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedTimeStamp", "Password", "Username" },
                values: new object[] { new Guid("c4026226-348a-4950-be73-377f2c6161d6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sarwan", "sarwan" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedTimeStamp", "Password", "Username" },
                values: new object[] { new Guid("08cffbc5-14a5-474e-b7b1-38cfd83db3fd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "postgres", "postgres" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("08cffbc5-14a5-474e-b7b1-38cfd83db3fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4026226-348a-4950-be73-377f2c6161d6"));

            migrationBuilder.DropColumn(
                name: "CreatedTimeStamp",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { new Guid("41a3e297-4e6b-4c81-8fe1-c55d8bdd025b"), "sarwan", "sarwan" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { new Guid("642e8931-043e-4c1e-b2ba-b128160593f7"), "postgres", "postgres" });
        }
    }
}
