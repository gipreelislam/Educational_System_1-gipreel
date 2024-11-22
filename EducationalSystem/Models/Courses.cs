using System;

namespace EducationalSystem.Models
{
    public class Courses
    {
        public int CourseID { get; set; }
        public string CourseTitle { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ThumbnailURL { get; set; }
        public double Price { get; set; }
        public ICollection<Lessons>? Lessons { get; set; }
        public ICollection<Discounts>? Discounts { get; set; }
        public ICollection<Assessments>? Assessments { get; set; }
        public ICollection<Course_Instructors>? Course_Instructors { get; set; }
        public ICollection<Course_Enrollments>? Course_Enrollments { get; set; }

        /*
o One-to-Many with Lessons
o One-to-Many with Discounts
o One-to-Many with Assessments
o Many-to-Many with Instructors through Course_Instructors
o One-to-Many with Course_Enrollments
 */
    }
}
