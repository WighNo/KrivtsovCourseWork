using System;
using System.Collections.Generic;
using System.Linq;
using KrivtsovCourseWork.Models;
using KrivtsovCourseWork.Models.DatabaseModel;
using Microsoft.AspNetCore.Mvc;

namespace KrivtsovCourseWork.Controllers
{
    public class VisitPatientController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        
        public VisitPatientController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IActionResult Index()
        {
            return View(_databaseContext);
        }
        
        [HttpPost]
        public IActionResult Index(string secondName, string firstName, string diagnosisId, string doctorId, string date)
        {
            Console.WriteLine("POST");

            if (secondName is null == true || firstName is null == true || diagnosisId is null == true || doctorId is null == true || date is null == true)
                return Index();

            Patient patient = new Patient();

            patient.SecondName = secondName;
            patient.FirstName = firstName;

            List<Diagnosis> diagnoses = new List<Diagnosis>();
            diagnoses.Add(_databaseContext.Diagnoses.First(d => d.Id == int.Parse(diagnosisId)));
            patient.Diagnosis = diagnoses;

            Doctor doctor = _databaseContext.Doctors.First(d => d.Id == int.Parse(doctorId));
            patient.Doctor = doctor;

            patient.Visit = new Visit { Date = DateTime.Parse(date) };

            _databaseContext.Add(patient);
            _databaseContext.SaveChanges();
            
            return Index();
        }
    }
}