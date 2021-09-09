using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Modul4HW3.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", maxLength: 7, nullable: false),
                    Revenue = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "DateOfBirth", "FirstName", "LastName", "Revenue" },
                values: new object[,]
                {
                    { 1, new DateTime(1943, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Henry", "Ford", 269000m },
                    { 2, new DateTime(1993, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pasha", "Pavlov", 70000000m },
                    { 3, new DateTime(1977, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Max", "Maximov", 29990m },
                    { 4, new DateTime(2000, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Liza", "Lizova", 130000m },
                    { 5, new DateTime(1934, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Don", "Red", 13000m }
                });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "Location", "Title" },
                values: new object[,]
                {
                    { 1, "USA, NewYork", "IT Office" },
                    { 2, "Ukraine, Kharkiv", "Zavod" }
                });

            migrationBuilder.InsertData(
                table: "Titles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Programmer" },
                    { 2, "Worker" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "FirstName", "HiredDate", "LastName", "OfficeId", "TitleId" },
                values: new object[,]
                {
                    { 1, new DateTime(1999, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vlad", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vladov", 1, 1 },
                    { 2, new DateTime(1990, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivan", new DateTime(2020, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stepanov", 1, 1 },
                    { 3, new DateTime(1954, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark", new DateTime(2000, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fedorov", 2, 2 },
                    { 4, new DateTime(1968, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tom", new DateTime(2010, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black", 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Budget", "ClientId", "Name", "StartedDate" },
                values: new object[,]
                {
                    { 1, 1550m, 1, "MyBestFrameWork", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 15500m, 2, "MyBestWebSite", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 15750m, 3, "antivirus", new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1550m, 4, "SomeProject", new DateTime(1991, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1550m, 5, "SomeService", new DateTime(2001, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "EmployeeProject",
                columns: new[] { "Id", "EmployeeId", "ProjectId", "Rate", "StartedDate" },
                values: new object[,]
                {
                    { 1, 1, 1, 557m, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, 4, 100m, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 1, 557m, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, 1, 100m, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 3, 2, 557m, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 3, 5, 100m, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, 1, 100m, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 4, 3, 557m, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ClientId",
                table: "Projects",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Clients_ClientId",
                table: "Projects",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Clients_ClientId",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ClientId",
                table: "Projects");

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Projects");
        }
    }
}
