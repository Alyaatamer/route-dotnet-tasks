using Task4.Context;
using System.Text.Json;
using Task4.Models;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Data Seed
            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated();

                if (!context.Departments.Any())
                {
                    var departments = JsonSerializer.Deserialize<List<Department>>(
                            File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "Data", "departments.json"))
                    );

                    context.Departments.AddRange(departments);
                    context.SaveChanges();
                }

                if (!context.Employees.Any())
                {
                    var employees = JsonSerializer.Deserialize<List<Employee>>(
                        File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "Data", "employees.json"))
                    );
                    context.Employees.AddRange(employees);
                    context.SaveChanges();
                }
            }

            // Console.WriteLine("Database seeded successfully!");
            #endregion

            #region Joins

            #region inner join

            //using (var context = new AppDbContext())
            //{
            //    var result = from e in context.Employees
            //                 join d in context.Departments
            //                 on e.DepartmentId equals d.Id
            //                 select new
            //                 {
            //                     EmployeeName = e.EmpName,
            //                     DepartmentName = d.Name
            //                 };

            //    foreach(var item in result)
            //    {
            //        Console.WriteLine($"EmpName : {item.EmployeeName} => DeptName : {item.DepartmentName}");
            //    }
            //}


            //using (var context = new AppDbContext())
            //{
            //    var result = context.Employees
            //                 .Join(context.Departments,
            //                 e => e.DepartmentId, d => d.Id,
            //                 (e, d) => new
            //                 {
            //                     EmployeeName = e.EmpName,
            //                     DepartmentName = d.Name
            //                 });

            //    foreach (var item in result)
            //    {
            //        Console.WriteLine($"EmpName : {item.EmployeeName} => DeptName : {item.DepartmentName}");
            //    }
            //}

            #endregion

            #region outer Join

            //using (var context = new AppDbContext())
            //{
            //    var result = from e in context.Employees
            //                 join d in context.Departments
            //                 on e.DepartmentId equals d.Id into deptGroup
            //                 from d in deptGroup.DefaultIfEmpty()
            //                 select new
            //                 {
            //                     EmployeeName = e.EmpName,
            //                     DepartmentName = d.Name
            //                 };

            //    foreach (var item in result)
            //    {
            //        Console.WriteLine($"EmpName : {item.EmployeeName} => DeptName : {item.DepartmentName}");
            //    }
            //}

            //using (var context = new AppDbContext())
            //{
            //    var result = context.Employees
            //                .GroupJoin(context.Departments,
            //                            e => e.DepartmentId,
            //                            d => d.Id,
            //                            (e, deptGroup) => new { e, deptGroup })
            //                .SelectMany(
            //                            x => x.deptGroup.DefaultIfEmpty(),
            //                            (x, d) => new
            //                            {
            //                                EmployeeName = x.e.EmpName,
            //                                DepartmentName =  d.Name 
            //                            });

            //    foreach (var item in result)
            //    {
            //        Console.WriteLine($"EmpName : {item.EmployeeName} => DeptName : {item.DepartmentName}");
            //    }
            //}


            #endregion

            #region cross join

            //using (var context = new AppDbContext())
            //{
            //    var result = from e in context.Employees
            //                 from d in context.Departments
            //                 select new
            //                 {
            //                     EmployeeName = e.EmpName,
            //                     DepartmentName = d.Name
            //                 };

            //    foreach (var item in result)
            //    {
            //        Console.WriteLine($"EmpName : {item.EmployeeName} => DeptName : {item.DepartmentName}");
            //    }
            //}


            //using (var context = new AppDbContext())
            //{
            //    var result = context.Employees
            //                           .SelectMany(e => context.Departments,
            //                                       (e, d) => new
            //                                       {
            //                                           EmployeeName = e.EmpName,
            //                                           DepartmentName = d.Name
            //                                       });

            //    foreach (var item in result)
            //    {
            //        Console.WriteLine($"EmpName : {item.EmployeeName} => DeptName : {item.DepartmentName}");
            //    }
            //}


            #endregion

            #endregion


        }
    }
}
