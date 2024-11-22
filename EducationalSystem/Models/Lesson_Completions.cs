namespace EducationalSystem.Models
{
    public class Lesson_Completions
    {
        public int CompletionID { get; set; }
        public int UserID { get; set; }
        public int LessonID { get; set; }
        public DateTime CompletionDate { get; set; }
    }
}
