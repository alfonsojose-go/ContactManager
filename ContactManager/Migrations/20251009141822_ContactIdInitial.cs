using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ContactManager.Migrations
{
    /// <inheritdoc />
    public partial class ContactIdInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "ContactId",
                table: "Contacts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.Sql(@"
            INSERT INTO [Contact] ([FirstName], [LastName], [Phone], [Email], [Organization], [CategoryId], [DateAdded])
            VALUES 
            ('John', 'Doe', '1234567890', 'john.doe@contactsmanager.com', 'Contacts Manager Inc.', 3, '01-15-2024 at 10:30:45 AM'),
            ('Jane', 'Smith', '9876543210', 'jane.smith@contactsmanager.com', 'Contacts Manager Inc.', 2, '01-15-2024 at 11:15:20 AM'),
            ('Michael', 'Johnson', '5551234567', 'michael.johnson@contactsmanager.com', 'Contacts Manager Inc.', 1, '01-15-2024 at 02:45:10 PM')
        ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ContactId",
                table: "Contacts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "CategoryId", "DateAdded", "Email", "FirstName", "LastName", "Organization", "Phone" },
                values: new object[,]
                {
                    { 1, 3, "01-15-2024 at 10:30:45 AM", "john.doe@contactsmanager.com", "John", "Doe", "Contacts Manager Inc.", "1234567890" },
                    { 2, 2, "01-15-2024 at 11:15:20 AM", "jane.smith@contactsmanager.com", "Jane", "Smith", "Contacts Manager Inc.", "9876543210" },
                    { 3, 1, "01-15-2024 at 02:45:10 PM", "michael.johnson@contactsmanager.com", "Michael", "Johnson", "Contacts Manager Inc.", "5551234567" }
                });

            migrationBuilder.Sql("DELETE FROM [Contact] WHERE [Email] IN ('john.doe@contactsmanager.com','jane.smith@contactsmanager.com','michael.johnson@contactsmanager.com')");
        }
    }
}
