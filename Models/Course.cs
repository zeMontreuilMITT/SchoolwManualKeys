using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolwManualKeys.Models
{
    public class Course
    {
        [Key]
        [Display(Name = "Course Number")]
        public int CourseNumber { get; set; }


        [StringLength(100, MinimumLength = 3)]
        public string Title { get; set; }


        [ForeignKey("EnrolledCourseNumber")]
        public ICollection<Enrollment> Enrollments { get; set; }

        public Course()
        {
            Enrollments = new HashSet<Enrollment>();
        }
    }
}
