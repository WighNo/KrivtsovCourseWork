using System;
using System.Collections.Generic;
using System.Linq;
using KrivtsovCourseWork.Models;
using KrivtsovCourseWork.Models.DatabaseModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KrivtsovCourseWork.Controllers
{
    public class PatientViewController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        
        public PatientViewController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            
            _databaseContext.Diagnoses.Load();
            _databaseContext.Visits.Load();
        }
        
        public IActionResult Index()
        {
            List<Patient> patients = _databaseContext.Patient.ToList();
            
            return View(patients);
        }
    }
}