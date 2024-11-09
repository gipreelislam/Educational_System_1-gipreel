namespace EducationalSystem.Models
{
    public class Choices : BaseEntity
    {
        public string ChoiceText { get; set; }
        public bool IsCorrect { get; set; }
    }
}
