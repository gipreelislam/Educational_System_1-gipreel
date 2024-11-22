using System;

namespace EducationalSystem.Models
{
    public class Discounts
    {
        int DiscountID { get; set; }
        public string CourseID { get; set; }
        public int DiscountValue { get; set; }
        public DateTime StartDate {  get; set; }
        public DateTime EndDate { get; set; }

    }
}
