namespace EducationalSystem.Models
{
    public class Lessons : BaseEntity
    {
        public string LessonTitle { get; set; }
        public string Content { get; set; }
        public int LessonOrder {  get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
