using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ContactManager.Migrations
{
    /// <inheritdoc />
    public partial class FixContactIdIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "CategoryId", "DateAdded", "Email", "FirstName", "LastName", "Organization", "Phone" },
                values: new object[,]
                {
                    { -3, 1, "01-15-2024 at 02:45:10 PM", "michael.johnson@contactsmanager.com", "Michael", "Johnson", "Contacts Manager Inc.", "5551234567" },
                    { -2, 2, "01-15-2024 at 11:15:20 AM", "jane.smith@contactsmanager.com", "Jane", "Smith", "Contacts Manager Inc.", "9876543210" },
                    { -1, 3, "01-15-2024 at 10:30:45 AM", "john.doe@contactsmanager.com", "John", "Doe", "Contacts Manager Inc.", "1234567890" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: -1);
        }
    }
}
