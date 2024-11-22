namespace EducationalSystem.Models
{
    public class Categories
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Courses> Courses { get; set; }
    }
}
