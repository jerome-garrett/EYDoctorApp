namespace DoctorsApp.Models
{
    public class DoctorLanguage
    {
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; } 
    }
}