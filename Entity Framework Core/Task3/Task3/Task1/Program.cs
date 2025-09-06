using Microsoft.EntityFrameworkCore;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1
            //using (var context = new ITIContext())
            //{
            //    var department = new Department
            //    {
            //        Name = "sales",
            //    };
            //    context.Departments.Add(department);
            //    context.SaveChanges();

            //    var manager = new Instructor
            //    {
            //        Name = "Alyaa",
            //        Dept_ID = department.ID
            //    };
            //    context.Instructors.Add(manager);
            //    context.SaveChanges();

            //    //Update Department with ManagerId
            //    department.ManagerId = manager.ID;
            //    context.Departments.Update(department);
            //    context.SaveChanges();

            //    //--------------------------------------------------------
            //    var student = new Student
            //    {
            //        FName = "aliaa",
            //        Dept_ID = department.ID
            //    };
            //    context.Students.Add(student);
            //    context.SaveChanges();

            //    var topic = new Topic
            //    {
            //        Name = "Programming"
            //    };
            //    context.Topics.Add(topic);
            //    context.SaveChanges();

            //    var course = new Course
            //    {
            //        Name = "C# Basics",
            //        Top_ID = topic.ID
            //    };
            //    context.courses.Add(course);
            //    context.SaveChanges();

            //    //Student-Course
            //    var studCourse = new Stud_Course
            //    {
            //        Stud_ID = student.ID,
            //        Course_ID = course.ID,
            //        Grade = 95
            //    };
            //    context.Stud_Courses.Add(studCourse);
            //    context.SaveChanges();

            //    //Instructor-Course
            //    var courseInst = new Course_Inst
            //    {
            //        Inst_ID = manager.ID,
            //        Course_ID = course.ID,
            //        Evaluation = "Excellent"
            //    };
            //    context.Course_Insts.Add(courseInst);
            //    context.SaveChanges();

            //    Console.WriteLine("All Data Inserted Successfully!");
            //}




            //using (var context = new ITIContext())
            //{
            //    var students = context.Students.ToList();
            //    foreach (var s in students)
            //    {
            //        Console.WriteLine($"{s.ID} - {s.FName}");
            //    }
            //}

            #endregion



            #region 2
            //using (var context = new ITIContext())
            //{
            //    // ---------- INSERT ----------
            //    var department = new Department { Name = "IT" };
            //    context.Departments.Add(department);
            //    context.SaveChanges();

            //    var manager = new Instructor { Name = "soher", Dept_ID = department.ID };
            //    context.Instructors.Add(manager);
            //    context.SaveChanges();

            //    department.ManagerId = manager.ID;
            //    context.Departments.Update(department);
            //    context.SaveChanges();

            //    var student = new Student { FName = "Ali", Dept_ID = department.ID };
            //    context.Students.Add(student);
            //    context.SaveChanges();

            //    var topic = new Topic { Name = "LinQ" };
            //    context.Topics.Add(topic);
            //    context.SaveChanges();

            //    var course = new Course { Name = "SQL Basics", Top_ID = topic.ID };
            //    context.courses.Add(course);
            //    context.SaveChanges();

            //    var studCourse = new Stud_Course
            //    {
            //        Stud_ID = student.ID,
            //        Course_ID = course.ID,
            //        Grade = 88
            //    };
            //    context.Stud_Courses.Add(studCourse);
            //    context.SaveChanges();

            //    var courseInst = new Course_Inst
            //    {
            //        Inst_ID = manager.ID,
            //        Course_ID = course.ID,
            //        Evaluation = "Very Good"
            //    };
            //    context.Course_Insts.Add(courseInst);
            //    context.SaveChanges();

            //    Console.WriteLine("Insert Done!");
            //}

            //// ---------- SELECT ----------
            //using (var context = new ITIContext())
            //{
            //    var students = context.Students.ToList();
            //    Console.WriteLine("All Students:");
            //    foreach (var s in students)
            //        Console.WriteLine($"{s.ID} - {s.FName}");
            //}

            //// ---------- UPDATE ----------
            //using (var context = new ITIContext())
            //{
            //    var student = context.Students.FirstOrDefault();
            //    if (student != null)
            //    {
            //        student.FName = "Ali Updated";
            //        context.SaveChanges();
            //        Console.WriteLine("Student Updated!");
            //    }
            //}

            //// ---------- EAGER LOADING ----------
            //using (var context = new ITIContext())
            //{
            //    var studentWithCourses = context.Students
            //        .Where(s => s.ID == 1)
            //        .Include(s => s.Stud_Courses)
            //        .ThenInclude(sc => sc.Course)
            //        .FirstOrDefault();

            //    if (studentWithCourses != null)
            //    {
            //        Console.WriteLine($"Student: {studentWithCourses.FName}");
            //        foreach (var sc in studentWithCourses.Stud_Courses)
            //            Console.WriteLine($"Course: {sc.Course.Name} - Grade: {sc.Grade}");
            //    }
            //}

            //// ---------- LAZY LOADING ----------
            //using (var context = new ITIContext())
            //{
            //    var student = context.Students.FirstOrDefault();
            //    if (student != null)
            //    {
            //        Console.WriteLine($"Student: {student.FName}");
            //        foreach (var sc in student.Stud_Courses)
            //            Console.WriteLine($"Course: {sc.Course.Name} - Grade: {sc.Grade}");
            //    }
            //}


            //// ---------- DELETE ----------
            //using (var context = new ITIContext())
            //{
            //    var student = context.Students.FirstOrDefault();
            //    if (student != null)
            //    {
            //        context.Students.Remove(student);
            //        context.SaveChanges();
            //        Console.WriteLine("Student Deleted!");
            //    }
            //}

            #endregion

        }
    }
}
