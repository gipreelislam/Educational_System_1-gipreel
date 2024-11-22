namespace EducationalSystem.DAL.Models
{
    public class Questions : BaseEntity
    {
        public int QuestionID { get; set; }
        public int AssessmentID { get; set; }
        public string QuestionText { get; set; }
        public string QuestionType { get; set; }
        public int Points { get; set; }
        public ICollection<Choices> Choices { get; set; }
    }
}
