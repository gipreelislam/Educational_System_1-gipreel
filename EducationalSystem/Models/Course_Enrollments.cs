namespace EducationalSystem.Models
{
    public class Course_Enrollments
    {
        public int EnrollmentID { get; set; }
        public int UserID { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int CourseId { get; set; }

    }
}
