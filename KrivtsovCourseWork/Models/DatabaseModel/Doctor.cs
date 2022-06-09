namespace KrivtsovCourseWork.Models.DatabaseModel
{
    public class Doctor
    {
        public int Id { get; set; }
        
        public string SecondName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public string PhotoUrl { get; set; }
        
        public JobTitle JobTitle { get; set; }

        public string GetFullName() => $"{SecondName} {FirstName} {MiddleName}";
    }
}