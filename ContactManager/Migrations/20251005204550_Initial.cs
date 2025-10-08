using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ContactManager.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", "SqlServerValueGenerationStrategy.IdentityColumn"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAdded = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Organization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ContactId);
                    table.ForeignKey(
                        name: "FK_Contact_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Family" },
                    { 2, "Friend" },
                    { 3, "Work" },
                    { 4, "School" },
                    { 5, "Church" },
                    { 6, "Gym" },
                    { 7, "Others" }
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] {"CategoryId", "DateAdded", "Email", "FirstName", "LastName", "Organization", "Phone" },
                values: new object[,]
                {
                    { 3, "10-05-2025", "john.doe@contactsmanager.com", "John", "Doe", "Contacts Manager Inc.", "123-456-7890" },
                    { 2, "10-05-2025", "jane.smith@contactsmanager.com", "Jane", "Smith", "Contacts Manager Inc.", "987-654-3210" },
                    { 1, "10-05-2025", "michael.johnson@contactsmanager.com", "Michael", "Johnson", "Contacts Manager Inc.", "555-123-4567" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contact_CategoryId",
                table: "Contact",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
