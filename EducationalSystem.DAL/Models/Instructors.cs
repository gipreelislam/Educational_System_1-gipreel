namespace EducationalSystem.DAL.Models
{
    public class Instructors : BaseEntity
    {
        public int InstructorID { get; set; }
        public int UserID { get; set; }
        public string PhoneNumber { get; set; }
        public string CV_PDF_URL { get; set; }
        public string NationalCardImageURL {  get; set; }
        public string BIO {  get; set; }
        public ICollection<Courses>?Courses { get; set; }
        public ICollection<Instructor_Specializations>? GetInstructor_Specializations { get; set; }
        /*
         One-to-Many with Courses
o Many-to-Many with Specializations through Instructor_Specializations

         */
    }
}
