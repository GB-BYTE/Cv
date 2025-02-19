namespace Cv_webapp.Models
{
    public class HomeModel
    {
        public string? FullName { get; set; }
        public string? Bio { get; set; }
    }

    public class ExperienceModel
    {
        public string position { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public DateTime Year { get; set; }
    }

    public class Skills
    {
        
        //public List<Skills> TechnicalSkills { get; set; } = new List<Skills>();
        public string TechnicalSkills { get; set; }
    }

    public class Education
    {
        public string Institution { get; set; }
        public string Degree { get; set; }
        public DateOnly StartYear { get; set; }
        public  DateOnly EndYear { get; set; }
    }

    public class TaxModel
    {
        public decimal Amount { get; set; }
        public decimal TaxAmount { get; set; }
    }
}
