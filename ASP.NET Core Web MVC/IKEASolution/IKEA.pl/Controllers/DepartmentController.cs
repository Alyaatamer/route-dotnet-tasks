using Humanizer;
using IKEA.BLL.Dto_s.DepartmentDto_s;
using IKEA.BLL.Services.DepartmentServices.DepartmentServices;
using IKEA.pl.ViewModels.DepartmentVMs;
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

        #region Create
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
        #endregion

        #region Details
        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null || id <= 0) return BadRequest();
            var dept = departmentServices.GetDepartmentById(id.Value);
            if (dept == null) return NotFound();
            return View(dept);
        }
        #endregion

        #region Edit
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id <= 0) return BadRequest();
            var dept = departmentServices.GetDepartmentById(id.Value);
            if (dept == null) return NotFound();

            var departmentviewmodel = new DepartmentVM
            {
                Id = dept.Id,
                Name = dept.Name,
                Code = dept.Code,
                Description = dept.Description,
            };

            return View(departmentviewmodel);
        }
        [HttpPost]
        public IActionResult Edit([FromRoute] int? id, DepartmentVM model)
        {
            if (!ModelState.IsValid) return View(model);

            var department = new UpdatedDepartmentDto()
            {
                Id = id.Value,
                Name = model.Name,
                Description = model.Description,
                Code = model.Code,
            };

            try
            {
                int result = departmentServices.UpdateDepartment(department);
                if (result > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Department can't Be Updated!");
                    return View(model);
                }
            }
            catch (Exception ex)
            {
                if (webHost.IsDevelopment())
                {
                    logger.LogError(ex.Message);
                    return View(model);
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
            if(id == null) return BadRequest();
            
            var department = departmentServices.GetDepartmentById(id.Value);

            if (department == null) return NotFound();

            return View(department);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = departmentServices.DeleteDepartment(id);
                if (result > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Department can't be deleted!");
                    return RedirectToAction("Delete", new { id });
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error while deleting Department Id={Id}", id);
                return RedirectToAction("Delete", new { id });
            }
        }

        #endregion
    }
}
