namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee emp = new Employee
            {
                EmployeeID = 1,
                BD = new DateTime(1960, 5, 10),
                VacationStock = 5
            };

            bool vacationResult = emp.RequestVacation(DateTime.Now, DateTime.Now.AddDays(10));
            Console.WriteLine($"Vacation request approved? {vacationResult}");

            emp.EndOfYearOperation();


            Department dept = new Department { DeptID = 1, DeptName = "IT" };
            Club club = new Club { ClubID = 1, ClubName = "Company Club" };

            Employee emp1 = new Employee { EmployeeID = 1, BD = new DateTime(1960, 5, 10), VacationStock = 5 };
            SalesPerson emp2 = new SalesPerson { EmployeeID = 2, BD = new DateTime(1990, 8, 15), AchievedTarget = 50 };
            BoardMember emp3 = new BoardMember { EmployeeID = 3, BD = new DateTime(1955, 2, 20) };

            dept.AddStaff(emp1);
            dept.AddStaff(emp2);
            dept.AddStaff(emp3);

            club.AddMember(emp1);
            club.AddMember(emp2);
            club.AddMember(emp3);

            dept.ShowStaff();
            club.ShowMembers();

            Console.WriteLine("\n-- Test Scenarios --");

            // Employee normal requests vacation exceeding stock
            emp1.RequestVacation(DateTime.Now, DateTime.Now.AddDays(10));

            // SalesPerson failed target
            emp2.CheckTarget(100);

            // BoardMember resigns
            emp3.Resign();

            Console.WriteLine("\n-- After Events --");
            dept.ShowStaff();
            club.ShowMembers();


        }
    }
}
