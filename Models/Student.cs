using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolwManualKeys.Models
{
    public class Student
    {
        [Key]
        [Display(Name = "Student Number")]
        public int StudentNumber { get; set; }

        [Display(Name = "Full Name")]
        [StringLength(300)]
        public string FullName { get; set; }

        [ForeignKey("EnrolledStudent")]
        public ICollection<Enrollment> Enrollments { get; set; }

        public Student()
        {
            Enrollments = new HashSet<Enrollment>();
        }

    }
}
