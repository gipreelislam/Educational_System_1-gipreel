namespace EducationalSystem.DAL.Models
{
    public class Assessment_Results : BaseEntity
    {
        public int ResultID { get; set; }
        public int UserID { get; set; }
        public int Score {  get; set; }
        public DateTime? AttemptDate { get; set; }
    }
}
