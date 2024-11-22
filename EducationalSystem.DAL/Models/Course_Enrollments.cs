namespace EducationalSystem.DAL.Models
{
    public class Course_Enrollments : BaseEntity
    {
        public int EnrollmentID { get; set; }
        public int UserID { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int CourseId { get; set; }

    }
}
