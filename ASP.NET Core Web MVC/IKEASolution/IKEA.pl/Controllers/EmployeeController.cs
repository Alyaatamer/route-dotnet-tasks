using IKEA.BLL.Dto_s.DepartmentDto_s;
using IKEA.BLL.Dto_s.EmployeeDto_s;
using IKEA.BLL.Services.DepartmentServices.DepartmentServices;
using IKEA.BLL.Services.EmployeeServices;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace IKEA.pl.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeServices employee;
        private readonly ILogger<EmployeeController> logger;
        private readonly IWebHostEnvironment environment;

        public EmployeeController(IEmployeeServices employee,ILogger<EmployeeController> logger , IWebHostEnvironment environment)
        {
            this.employee = employee;
            this.logger = logger;
            this.environment = environment;
        }
        public IActionResult Index()
        {
            var emps = employee.GetAllEmployees();
            return View(emps);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

       
    }
}
