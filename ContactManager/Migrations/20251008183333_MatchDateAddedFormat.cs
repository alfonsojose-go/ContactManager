using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactManager.Migrations
{
    /// <inheritdoc />
    public partial class MatchDateAddedFormat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateAdded",
                value: "10-08-2025");

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateAdded",
                value: "10-08-2025");

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateAdded",
                value: "10-08-2025");
        }
    }
}
