using IKEA.BLL.Dto_s.EmployeeDto_s;
using IKEA.BLL.Services.DepartmentServices.DepartmentServices;
using IKEA.BLL.Services.EmployeeServices;
using IKEA.DAL.Models.Department;
using Microsoft.AspNetCore.Mvc;

namespace IKEA.pl.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeServices employee;
        private readonly ILogger<EmployeeController> logger;
        private readonly IWebHostEnvironment environment;

        public EmployeeController(IEmployeeServices employee,ILogger<EmployeeController> logger , IWebHostEnvironment environment )
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

        #region Create
        [HttpGet]
        public IActionResult Create() {
            return View();
        }
        

        [HttpPost]
        public IActionResult Create(CreatedEmployeeDto dto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    int result = employee.AddEmployee(dto);
                    if (result > 0)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Employee can't Be Created!");
                        return View(dto);
                    }
                }
                catch (Exception ex)
                {
                    if (environment.IsDevelopment())
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
        #endregion

        #region Details

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null || id <= 0) return BadRequest();
            var emp = employee.GetEmployeeById(id.Value);
            if (emp == null) return NotFound();
            return View(emp);
        }
        #endregion

        #region Edit
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id <= 0) return BadRequest();
            var emp = employee.GetEmployeeById(id.Value);
            if (emp == null) return NotFound();

            var mappedEmp = new UpdatedEmployeeDto
            {
                Id = emp.Id,
                Name = emp.Name,
                Age = emp.Age,
                Address = emp.Address,
                Salary = emp.Salary,
                IsActive = emp.IsActive,
                Email = emp.Email,
                PhoneNumber = emp.PhoneNumber,
                HiringDate = emp.HiringDate,
                Gender = emp.Gender,
                EmployeeType = emp.EmployeeType,
            };

            return View(mappedEmp);
        }
        [HttpPost]
        public IActionResult Edit(UpdatedEmployeeDto empDto)
        {
            if (!ModelState.IsValid) return View(empDto);

            var massage = string.Empty;

            try
            {
                int result = employee.UpdateEmployee(empDto);
                if (result > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Employee can't Be Updated!");
                    return View(empDto);
                }
            }
            catch (Exception ex)
            {
                if (environment.IsDevelopment())
                {
                    logger.LogError(ex.Message);
                    return View(empDto);
                }
                else
                {
                    throw;
                }
            }
        }
        #endregion

        #region Delete
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null) return BadRequest();

            var emp = employee.GetEmployeeById(id.Value);

            if (emp == null) return NotFound();

            return View(emp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = employee.DeleteEmployee(id);
                if (result > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Employee can't be deleted!");
                    return RedirectToAction("Delete", new { id });
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error while deleting Employee Id={Id}", id);
                return RedirectToAction("Delete", new { id });
            }
        }

        #endregion


    }
}
