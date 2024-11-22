namespace EducationalSystem.Models
{
    public class Specializations
    {
        public int SpecializationID { get; set; }
        public string SpecializationName { get; set; }
        public ICollection<Instructor_Specializations> Instructor_Specializations { get; set; }

    }
}
