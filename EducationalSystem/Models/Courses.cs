namespace EducationalSystem.Models
{
    public class Courses : BaseEntity
    {
        public string CourseTitle { get; set; }
        public string Description { get; set; }
        public string ThumbnailURL { get; set; }
        public decimal TotalAmount { get; set; }    
        public DateTime? CreatedDate { get; set; }
    }
}
