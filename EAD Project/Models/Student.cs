using System.ComponentModel.DataAnnotations;

namespace EAD_Project.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        // Add other properties as needed
    }
}
