using Microsoft.CodeAnalysis;

namespace EducationalSystem.Models
{
    public class Assessments : BaseEntity
    {
        public int AssessmentID { get; set; }
        public int CourseID { get; set; }
        public int LessonID { get; set; }
        public string AssessmentType { get; set; }
        public int MaxScore { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<Questions> Questions { get; set; }
    }
}
