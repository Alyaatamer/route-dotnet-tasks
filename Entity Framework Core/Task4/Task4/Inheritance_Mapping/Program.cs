using Inheritance_Mapping.Context;
using Inheritance_Mapping.Models;

namespace Inheritance_Mapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using TextContext context = new TextContext();

            //Employee employee = new Employee()
            //{
            //    Name = "alyaa",
            //    Age = 20,
            //    Address = "Cairo"
            //};
            //context.Employees.Add(employee);

            //FullTimeEmployee FTEmployee = new FullTimeEmployee()
            //{
            //    Name = "soher",
            //    Age = 21,
            //    Address = "cairo",
            //    StartDate = DateOnly.FromDateTime(DateTime.Now),
            //    Salary = 20000
            //};
            //context.FullTimeEmployees.Add(FTEmployee);

            //PartTimeEmployee PTEmployee = new PartTimeEmployee()
            //{
            //    Name = "engy",
            //    Age = 20,
            //    Address = "cairo",
            //    HourRate = 800,
            //    CountOfHours = 80
            //};
            //context.PartTimeEmployees.Add(PTEmployee);

            //context.SaveChanges();

            //var Emps = context.Employees.ToList();

            //if (Emps.Count > 0)
            //{
            //    Console.WriteLine("Full Time Employees:");
            //    foreach (var ft in Emps.OfType<FullTimeEmployee>())
            //    {
            //        Console.WriteLine($"Name: {ft.Name}, Salary: {ft.Salary}");
            //    }

            //    Console.WriteLine("====================================================");

            //    Console.WriteLine("Part Time Employees:");
            //    foreach (var pt in Emps.OfType<PartTimeEmployee>())
            //    {
            //        Console.WriteLine($"Name: {pt.Name}, HourRate: {pt.HourRate}, Hours: {pt.CountOfHours}");
            //    }
            //}

            //Console.WriteLine("Done!");
        }
    }
}
