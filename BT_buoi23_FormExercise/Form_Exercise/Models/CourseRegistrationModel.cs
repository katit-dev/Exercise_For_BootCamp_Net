using System.ComponentModel.DataAnnotations;

namespace Form_Exercise.Models
{
    public class CourseRegistrationModel
    {
        [Required]
        [MinLength(3)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^\d{10,12}$")]
        public string Phone { get; set; }

        [Required]
        public string Course { get; set; }

        [Required(ErrorMessage = "Study mode is required")]
        public string StudyMode { get; set; }

        [Required]
        public DateTime? StartDate { get; set; }

        public string? Notes { get; set; }

        [Range(typeof(bool), "true", "true")]
        public bool Agree { get; set; }
    }
}