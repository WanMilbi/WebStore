using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _Configuration;

        private static readonly List<Employee> __Employees = new()
        {
            new Employee { Id = 1, LastName = "Иванов", FirstName = "Иван", Patronymic = "Иванович", Age = 26 },
            new Employee { Id = 2, LastName = "Петров", FirstName = "Пётр", Patronymic = "Петрович", Age = 27 },
            new Employee { Id = 3, LastName = "Сидоров", FirstName = "Сидор", Patronymic = "Сидорович", Age = 28 },
        };
        public HomeController(IConfiguration Configuration) => _Configuration = Configuration;

        public IActionResult Index()
        {
            //return Content(_Configuration["ControllerActionText"]);
            return View();
        }

        public IActionResult SecondAction() 
        {
            return Content("Second controller action");
    }

        public IActionResult Employees()
        {
return View(__Employees);
        }

        public IActionResult More(int id)
        {
            return View(__Employees.Where(e => e.Id == id).First());
        }
}
}
    

