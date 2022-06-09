using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace KrivtsovCourseWork.Models.DatabaseModel
{
    [Keyless]
    public class PatientDiagnosis
    {
        public List<Diagnosis> Diagnoses { get; set; }
        public List<Patient> Patients { get; set; }
    }
}   