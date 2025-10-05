using IKEA.BLL.Dto_s.DepartmentDto_s;
using IKEA.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace IKEA.pl.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentServices departmentServices;
        private readonly ILogger<DepartmentController> logger;
        private readonly IWebHostEnvironment webHost;

        public DepartmentController(IDepartmentServices department,ILogger<DepartmentController> logger , IWebHostEnvironment webHost)
        {
            this.departmentServices = department;
            this.logger = logger;
            this.webHost = webHost;
        }
        public IActionResult Index()
        {
            var depts = departmentServices.GetAllDepartments();
            return View(depts);
        }
        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(CreatedDepartmentDto dto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    int result = departmentServices.AddDepartment(dto);
                    if (result > 0)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Department can't Be Created!");
                        return View(dto);
                    }
                }
                catch (Exception ex)
                {
                    if (webHost.IsDevelopment())
                    {
                        logger.LogError(ex.Message);
                        return View(dto);
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            else
            {
                return View(dto);
            }
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null || id <= 0) return BadRequest();
            var dept = departmentServices.GetDepartmentById(id.Value);
            if (dept == null) return NotFound();
            return View(dept);
        }
    }
}
