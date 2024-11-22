namespace EducationalSystem.Models
{
    public class Lesson_Completions : BaseEntity
    {
        public int CompletionID { get; set; }
        public int UserID { get; set; }
        public int LessonID { get; set; }
        public DateTime CompletionDate { get; set; }

    }
}
