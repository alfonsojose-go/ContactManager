using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactManager.Migrations
{
    /// <inheritdoc />
    public partial class fixedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateAdded",
                value: "10-07-2025");

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateAdded",
                value: "10-07-2025");

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateAdded",
                value: "10-07-2025");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateAdded",
                value: "10-05-2025");

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateAdded",
                value: "10-05-2025");

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateAdded",
                value: "10-05-2025");
        }
    }
}
