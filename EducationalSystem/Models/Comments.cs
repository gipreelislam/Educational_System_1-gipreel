namespace EducationalSystem.Models
{
    public class Comments
    {
        public int CommentID { get; set; }
        public int LessonID { get; set; }
        public int UserID { get; set; }
        public string CommentText { get; set; }
        public DateTime PostedDate { get; set; }

    }
}
