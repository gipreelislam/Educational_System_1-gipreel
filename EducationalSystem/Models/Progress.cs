namespace EducationalSystem.Models
{
    public class Progress : BaseEntity
    {
        public int Score { get; set; }
        public DateTime CompletedDate { get; set; }
    }
}
