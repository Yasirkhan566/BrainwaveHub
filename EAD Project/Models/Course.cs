using System.ComponentModel.DataAnnotations;

namespace EAD_Project.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        
    }

}
