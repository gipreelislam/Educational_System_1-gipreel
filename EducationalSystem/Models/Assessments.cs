namespace EducationalSystem.Models
{
    public class Assessments : BaseEntity
    {
        public string AssessmentType { get; set; }
        public int MaxScore { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
