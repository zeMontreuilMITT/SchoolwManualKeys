using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolwManualKeys.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        public Course Course { get; set; }
        public int EnrolledCourseNumber { get; set; }

        public Student Student { get; set; }
        public int EnrolledStudentNumber { get; set; }

        public double Grade { get; set; }
    }
}
