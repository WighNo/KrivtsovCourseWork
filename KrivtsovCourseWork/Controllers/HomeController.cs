using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KrivtsovCourseWork.Models;
using KrivtsovCourseWork.Models.DatabaseModel;
using Microsoft.EntityFrameworkCore;

namespace KrivtsovCourseWork.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DatabaseContext _databaseContext;

        public HomeController(ILogger<HomeController> logger, DatabaseContext databaseContext)
        {
            _logger = logger;
            _databaseContext = databaseContext;
            
            _databaseContext.JobTitle.Load();
            
            /*List<JobTitle> jobTitles = new List<JobTitle>()
            {   
                new JobTitle()
                {
                    Name = "Окулист"
                },
                new JobTitle()
                {
                    Name = "Психиатр"
                },
                new JobTitle()
                {
                    Name = "Уролог"
                },
                new JobTitle()
                {
                    Name = "Терапевт"
                }
            };
*/
            /*
            List<Doctor> doctors = new List<Doctor>()
            {
                new Doctor()
                {
                    SecondName = "Семёнович",
                    FirstName = "Айгуль",
                    MiddleName = "Юрьевна",
                    JobTitle = new JobTitle {Name = "Окулист"}
                },
                new Doctor()
                {
                    SecondName = "Цуриков",
                    FirstName = "Антон",
                    MiddleName = "Сергеевич",
                    JobTitle = new JobTitle {Name = "Психиатр"}
                },
                new Doctor()
                {
                    SecondName = "Рабцов",
                    FirstName = "Роберт",
                    MiddleName = "Антилопович",
                    JobTitle = new JobTitle {Name = "Уролог"}
                },
                new Doctor()
                {
                    SecondName = "Верховцев",
                    FirstName = "Анатолий",
                    MiddleName = "Анатольевич",
                    JobTitle = new JobTitle {Name = "Терапевт"}
                }
            };
*/

 //           _databaseContext.SaveChanges();
        }

        public IActionResult Index()
        {
            return View(_databaseContext.Doctors.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}