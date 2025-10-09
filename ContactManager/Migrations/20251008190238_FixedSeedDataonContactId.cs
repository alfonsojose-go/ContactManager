using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactManager.Migrations
{
    /// <inheritdoc />
    public partial class FixedSeedDataonContactId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "ContactId","CategoryId", "DateAdded", "Email", "FirstName", "LastName", "Organization", "Phone" },
                values: new object[,]
                {
                    { 1,3, "10-05-2025", "john.doe@contactsmanager.com", "John", "Doe", "Contacts Manager Inc.", "123-456-7890" },
                    { 2,2, "10-05-2025", "jane.smith@contactsmanager.com", "Jane", "Smith", "Contacts Manager Inc.", "987-654-3210" },
                    { 3,1, "10-05-2025", "michael.johnson@contactsmanager.com", "Michael", "Johnson", "Contacts Manager Inc.", "555-123-4567" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
