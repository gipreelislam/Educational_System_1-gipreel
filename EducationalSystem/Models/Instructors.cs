namespace EducationalSystem.Models
{
    public class Instructors : BaseEntity
    {
        public string PhoneNumber { get; set; }
        public string CV_PDF_URL { get; set; }
        public string NationalCardImageURL { get; set; }
        public string Bio { get; set; }
        public string Specializations { get; set; }

        
    }
}
