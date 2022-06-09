using System.Collections.Generic;

namespace KrivtsovCourseWork.Models.DatabaseModel
{
    public class Patient
    {
        public int Id { get; set; }
        
        public string SecondName { get; set; }
        public string FirstName { get; set; }     
        
        public Doctor Doctor { get; set; }
        
        public Visit Visit { get; set; }
        public List<Diagnosis> Diagnosis { get; set; }
    }
}