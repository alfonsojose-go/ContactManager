using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactManager.Migrations
{
    /// <inheritdoc />
    public partial class MakeOrganizationNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Organization",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Organization",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
