using System.ComponentModel.DataAnnotations;

namespace Form_Exercise.Models
{
     public class CustomerContactModel
    {
        [Required(ErrorMessage = "Full name is required")]
        [MinLength(3, ErrorMessage = "At least 3 characters")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [RegularExpression(@"^\d{10,12}$", ErrorMessage = "Phone must be 10-12 digits")]
        public string Phone { get; set; }

        [MinLength(5, ErrorMessage = "At least 5 characters")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Message is required")]
        [MinLength(10, ErrorMessage = "At least 10 characters")]
        public string Message { get; set; }

        [Required(ErrorMessage = "Please select a service")]
        public string Service { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "Must agree")]
        public bool Agree { get; set; }
    }
}