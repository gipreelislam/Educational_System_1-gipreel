namespace EducationalSystem.Models
{
    public class Assessment_Results : BaseEntity
    {
        public int Score {  get; set; }
        public DateTime? AttemptDate { get; set; }
    }
}
