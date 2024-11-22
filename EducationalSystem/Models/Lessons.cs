namespace EducationalSystem.Models
{
    public class Lessons
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Lesson_Prerequisites> Prerequisites { get; set; }
        public ICollection<Assessments> Assessments { get; set; }
        public ICollection<Comments> Comments { get; set; }
        /*
          One-to-Many with Lesson_Prerequisites
o One-to-Many with Assessments
o One-to-Many with Comments
         */
    }
}
