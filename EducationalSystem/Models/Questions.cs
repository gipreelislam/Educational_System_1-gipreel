namespace EducationalSystem.Models
{
    public class Questions : BaseEntity
    {
        public string QuestionText { get; set; }
        public string QuestionType { get; set; }
        public int Points { get; set; }
    }
}
