namespace EducationalSystem.DAL.Models
{
    public class Lessons : BaseEntity
    {
        public int LessonID { get; set; }
        public int CourseID { get; set; }
        public string LessonTitle { get; set; }
        public string Content { get; set; }
        public int LessonOrder { get; set; }
        public DateTime? CreatedDate { get; set; }
        public ICollection<Lesson_Prerequisites> Prerequisites { get; set; }
        public ICollection<Assessments> Assessments { get; set; }
        public ICollection<Comments> Comments { get; set; }

    }
}
