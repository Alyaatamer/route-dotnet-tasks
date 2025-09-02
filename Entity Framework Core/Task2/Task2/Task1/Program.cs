using Task2.Contexts;
using Task2.Models;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Students

            //create
           // using (var context = new ITIContext())
          //  {
               // var student = new Student { FName = "Alyaa", LName = "Tamer", Address = "Cairo", Dept_ID = 1 };
                // Console.WriteLine(context.Entry<Student>(student).State);
               // context.Students.Add(student);
                // Console.WriteLine(context.Entry<Student>(student).State);
               // context.SaveChanges();
                // Console.WriteLine(context.Entry<Student>(student).State); 

             
                //Read
                //var All = context.Students.ToList();
                //foreach(var s in All)
                //{
                //    Console.WriteLine($"Name : {s.FName} {s.LName}\nID: {s.ID}");
                //}

               
                //Update
                //var alyaa = context.Students.FirstOrDefault(s =>s.ID==1);
                //alyaa.Address = "Maadi";
                //context.SaveChanges();

                
                //Delete
                //var cairo = context.Students.FirstOrDefault(s => s.Address == "Cairo");
                //context.Students.Remove(cairo);
                //context.SaveChanges();

                
          //  }
            #endregion

            #region Deparements

            //create
            using (var context = new ITIContext())
            {
                var dept = new Department { Name = "EF Core" };
                Console.WriteLine(context.Entry<Department>(dept).State);
                context.Departments.Add(dept);
                Console.WriteLine(context.Entry<Department>(dept).State);
                context.SaveChanges();
                Console.WriteLine(context.Entry<Department>(dept).State);


                //Read
                //var All = context.Departments.ToList();
                //foreach (var d in All)
                //{
                //    Console.WriteLine($"Name : {d.Name}\nID: {d.ID}");
                //}


                //Update
                //var EF = context.Departments.FirstOrDefault(s => s.ID == 1);
                //EF.Name = "LinQ";
                //context.SaveChanges();


                //Delete
                //var d = context.Departments.FirstOrDefault(d => d.ID==1);
                //context.Departments.Remove(d);
                //context.SaveChanges();


            }
            #endregion


        }
    }
}
