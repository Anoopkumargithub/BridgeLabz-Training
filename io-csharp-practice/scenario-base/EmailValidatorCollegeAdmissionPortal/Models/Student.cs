using System.ComponentModel.DataAnnotations;

namespace EmailValidatorCollegeAdmissionPortal.Models
{
    public class Student
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [MinLength(2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [RegularExpression(
            @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$",
            ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        public Student(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }
}
