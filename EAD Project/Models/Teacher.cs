using System.ComponentModel.DataAnnotations;
namespace EAD_Project.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        // Add other properties as needed

        // Navigation property for courses
        public ICollection<Course> Courses { get; set; }
        // Navigation property for feedbacks received
        public ICollection<Feedback> FeedbacksReceived { get; set; }
    }

}
