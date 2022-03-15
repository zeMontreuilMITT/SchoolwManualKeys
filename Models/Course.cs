using System.ComponentModel.DataAnnotations;

namespace SchoolwManualKeys.Models
{
    public class Course
    {
        [Key]
        [Display(Name = "Course Number")]
        public int CourseNumber { get; set; }

        [StringLength(100, MinimumLength = 3)]
        public string Title { get; set; }
    }
}
