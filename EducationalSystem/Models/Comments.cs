namespace EducationalSystem.Models
{
    public class Comments : BaseEntity
    {
        public string CommentText {  get; set; }
        public DateTime PostedDate { get; set; }
    }
}
