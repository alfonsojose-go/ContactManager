using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ContactManager.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a last name.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a phone number.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be exactly 10 digits")]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter an email address.")]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public string DateAdded { get; set; } = $"{DateTime.Now:MM-dd-yyyy} at {DateTime.Now:hh:mm:ss tt}";

        [Display(Name = "Organization (Optional)")]
        public string? Organization { get; set; } = string.Empty;

        [Required(ErrorMessage = "Category is required.")]
        public int CategoryId { get; set; }

        [ValidateNever]
        public Category Category { get; set; } = null!;

        // Read-only property to generate a URL-friendly slug
        public string Slug
        {
            get
            {
                string fullName = $"{FirstName} {LastName}".ToLowerInvariant();

                // Replace spaces/underscores with hyphens
                string slug = Regex.Replace(fullName, @"[\s_]+", "-");

                // Remove invalid characters
                slug = Regex.Replace(slug, @"[^a-z0-9\-]", "");

                // Trim leading/trailing hyphens
                slug = slug.Trim('-');

                return slug;
            }
        }
    }
}
