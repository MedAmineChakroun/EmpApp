using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JokesApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedemp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "DateOfHire", "DateOfTermination", "Email", "FirstName", "IsActive", "LastName", "PhoneNumber", "Position", "Salary" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "john.doe@example.com", "John", true, "Doe", "1234567890", "Software Engineer", 60000m },
                    { 2, new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "jane.smith@example.com", "Jane", true, "Smith", "9876543210", "Project Manager", 75000m },
                    { 3, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "michael.johnson@example.com", "Michael", true, "Johnson", "1112223333", "QA Engineer", 50000m },
                    { 4, new DateTime(2018, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "emily.davis@example.com", "Emily", true, "Davis", "4445556666", "HR Manager", 65000m },
                    { 5, new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "robert.miller@example.com", "Robert", true, "Miller", "7778889999", "Data Analyst", 70000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
