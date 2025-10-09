using Microsoft.EntityFrameworkCore;

namespace ContactManager.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        { }

        public DbSet<Contact> Contact { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Category entity first
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoryId);
                entity.Property(e => e.CategoryName).IsRequired().HasMaxLength(50);

                entity.HasData(
                    new Category { CategoryId = 1, CategoryName = "Family" },
                    new Category { CategoryId = 2, CategoryName = "Friend" },
                    new Category { CategoryId = 3, CategoryName = "Work" },
                    new Category { CategoryId = 4, CategoryName = "School" },
                    new Category { CategoryId = 5, CategoryName = "Church" },
                    new Category { CategoryId = 6, CategoryName = "Gym" },
                    new Category { CategoryId = 7, CategoryName = "Others" }
                );
            });

            // Configure Contact entity
            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                // MAKE ContactId AN IDENTITY COLUMN
                entity.Property(e => e.ContactId)
                      .ValueGeneratedOnAdd();

                // Configure string properties with appropriate lengths
                entity.Property(e => e.FirstName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.LastName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Phone).IsRequired().HasMaxLength(15);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Organization).HasMaxLength(100);
                entity.Property(e => e.DateAdded).IsRequired().HasMaxLength(50);

                // Configure relationship
                entity.HasOne(c => c.Category)
                      .WithMany()
                      .HasForeignKey(c => c.CategoryId)
                      .OnDelete(DeleteBehavior.Restrict);

                // Seed data with TEMPORARY negative ContactId values
                // EF will ignore these and use actual identity values when inserting
                entity.HasData(
                    new Contact
                    {
                        ContactId = -1, // Temporary value - will be replaced by identity
                        FirstName = "John",
                        LastName = "Doe",
                        Phone = "1234567890", // Fixed: no hyphens to match validation
                        Email = "john.doe@contactsmanager.com",
                        Organization = "Contacts Manager Inc.",
                        CategoryId = 3,
                        DateAdded = "01-15-2024 at 10:30:45 AM"
                    },
                    new Contact
                    {
                        ContactId = -2, // Temporary value - will be replaced by identity
                        FirstName = "Jane",
                        LastName = "Smith",
                        Phone = "9876543210", // Fixed: no hyphens to match validation
                        Email = "jane.smith@contactsmanager.com",
                        Organization = "Contacts Manager Inc.",
                        CategoryId = 2,
                        DateAdded = "01-15-2024 at 11:15:20 AM"
                    },
                    new Contact
                    {
                        ContactId = -3, // Temporary value - will be replaced by identity
                        FirstName = "Michael",
                        LastName = "Johnson",
                        Phone = "5551234567", // Fixed: no hyphens to match validation
                        Email = "michael.johnson@contactsmanager.com",
                        Organization = "Contacts Manager Inc.",
                        CategoryId = 1,
                        DateAdded = "01-15-2024 at 02:45:10 PM"
                    }
                );
            });
        }
    }
}