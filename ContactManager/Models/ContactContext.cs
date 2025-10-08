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

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(e => e.Organization)
                      .IsRequired(false); // Make Organization field optional
            });

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Family" },
                new Category { CategoryId = 2, CategoryName = "Friend" },
                new Category { CategoryId = 3, CategoryName = "Work" },
                new Category { CategoryId = 4, CategoryName = "School" },
                new Category { CategoryId = 5, CategoryName = "Church" },
                new Category { CategoryId = 6, CategoryName = "Gym" },
                new Category { CategoryId = 7, CategoryName = "Others" }
            );

            modelBuilder.Entity<Contact>().HasData(

                new Contact {
                    ContactId = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Phone = "123-456-7890",
                    Email = "john.doe@contactsmanager.com",
                    Organization = "Contacts Manager Inc.",
                    CategoryId = 3,
                    DateAdded = DateTime.Now.ToString("MM-dd-yyyy")
                },

                new Contact
                {
                    ContactId = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Phone = "987-654-3210",
                    Email = "jane.smith@contactsmanager.com",
                    Organization = "Contacts Manager Inc.",
                    CategoryId = 2,
                    DateAdded = DateTime.Now.ToString("MM-dd-yyyy")
                },

                new Contact
                {
                    ContactId = 3,
                    FirstName = "Michael",
                    LastName = "Johnson",
                    Phone = "555-123-4567",
                    Email = "michael.johnson@contactsmanager.com",
                    Organization = "Contacts Manager Inc.",
                    CategoryId = 1,
                    DateAdded = DateTime.Now.ToString("MM-dd-yyyy")
                }
             );
        }
        


    }
}
