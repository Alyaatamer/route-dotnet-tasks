using static Task2.employee;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q2
            /*            
                2. Develop a Class to represent the Hiring Date Data:
                 Consisting of fields to hold the day, month and years
            */
            HiringDate hd = new HiringDate(13, 1, 2005);
            HiringDate hd1 = new HiringDate(14, 1, 2005);
            HiringDate hd2 = new HiringDate(13, 1, 2004);

            #endregion

            #region Q1
            /*
             1. Design and implement a Class for the employees in a company:
            */

            employee e1 = new employee(1,"Alyaa", securityLevel.guest,100000, hd, 'f');
            Console.WriteLine(e1);

            #endregion

            #region Q3
            /*             
                3. Create an array of Employees with size three a DBA, Guest and the
                third one is security officer who have full permissions. (Employee []
                EmpArr;)
            */
            employee[] EmpArr = new employee[3];

            EmpArr[0] = new employee(2, "DBA", securityLevel.DBA, 1500, hd, 'f');
            EmpArr[1] = new employee(3, "guest", securityLevel.guest, 2000, hd1, 'f');
            EmpArr[2] = new employee(4, "security officer", securityLevel.all, 200000, hd2, 'm');

            Console.WriteLine(EmpArr[0]);
            Console.WriteLine(EmpArr[1]);
            Console.WriteLine(EmpArr[2]);
            #endregion

            #region Q4

            /*           
                4. Sort the employees based on their hire date then Print the sorted
                array.
                 While sorting (how many times Boxing and Unboxing process
                has occurred)
            */

            Array.Sort(EmpArr, new ReverseClass());

            foreach (var emp in EmpArr)
            {
                Console.WriteLine(emp);
            }



            #endregion


        }
    }
}
