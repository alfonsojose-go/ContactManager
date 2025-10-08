using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactManager.Migrations
{
    /// <inheritdoc />
    public partial class StaticDataInDateAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateAdded",
                value: "01-15-2024 at 10:30:45 AM");

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateAdded",
                value: "01-15-2024 at 11:15:20 AM");

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateAdded",
                value: "01-15-2024 at 02:45:10 PM");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateAdded",
                value: "10-08-2025 at 12:33:31 PM");

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateAdded",
                value: "10-08-2025 at 12:33:32 PM");

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateAdded",
                value: "10-08-2025 at 12:33:32 PM");
        }
    }
}
