using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EAD_Project.Models
{
    public class Feedback
    {
        [Key]
        public int FeedbackId { get; set; }
        [Range(1, 5)]
        public int Rating { get; set; }
        [Required]
        public string Comment { get; set; }
        [DataType(DataType.Date)]
        public DateTime FeedbackDate { get; set; }
        // Add other properties as needed

        // Foreign keys
        
        public int StudentId { get; set; }
        public int TeacherId { get; set; }

        // Navigation properties
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
    }
}
