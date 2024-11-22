namespace EducationalSystem.Models
{
    public class Progress
    {
        public int ProgressID { get; set; }
        public int UserID { get; set; }
        public int CourseID { get; set; }
        public int Score { get; set; }
        public DateTime CompletedDate { get; set; }
    }
}
