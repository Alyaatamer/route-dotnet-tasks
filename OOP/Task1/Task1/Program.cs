using System.Security;
using static Task1.Program;

namespace Task1
{
    internal class Program
    {

        #region Q1
        public enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }

        #endregion

        #region Q2

        public struct Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public override string ToString()
            {
                return $"Name: {Name}, Age: {Age}";
            }
        }

        #endregion

        #region Q3

        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        #endregion

        #region Q4
        [Flags]
        enum Permissions
        {
            None = 0b_0000_0000,  // 0
            Read = 0b_0000_0001,  // 1
            Write = 0b_0000_0010,  // 2
            Delete = 0b_0000_0100,  // 4
            Excute = 0b_0000_1000,  // 8
        }

        #endregion

        #region Q5
        enum Colors
        {
            Red,
            Green,
            Blue
        }
        #endregion

        #region Q6

        struct Point
        {
            public double X;
            public double Y;

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
        }

        #endregion
        static void Main(string[] args)
        {
            #region Q1
            /*
             1. Create an enum called "WeekDays" with the days of the week (Monday to
                Sunday) as its members. Then, write a C# program that prints out all the
                days of the week using this enum.
            */

            foreach (WeekDays WD in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(WD);
            }
            #endregion

            #region Q2
            /*
             2. Define a struct "Person" with properties "Name" and "Age". Create an
                array of three "Person" objects and populate it with data. Then, write a C#
                program to display the details of all the persons in the array.
            */

            Person[] Person = new Person[3];

            Person[0] = new Person("Alyaa", 20);
            Person[1] = new Person("soher", 21);
            Person[2] = new Person("engy", 20);

            for (int i = 0; i < Person.Length; i++)
            {
                Console.WriteLine($"Name: {Person[i].Name}, Age: {Person[i].Age}");
            }

            #endregion

            #region Q3

            /*
             3. Create an enum called "Season" with the four seasons (Spring, Summer,
                Autumn, Winter) as its members. Write a C# program that takes a season
                name as input from the user and displays the corresponding month range
                for that season. Note range for seasons ( spring march to may , summer
                june to august , autumn September to November , winter December to
                February)
            */
            string str ;

            bool flag3 ;

            Season season;

            do
            {
                Console.Write("Enter a string : ");
                str = Console.ReadLine();
                flag3 = Enum.TryParse(str, true, out season);
            } while (!flag3);


            if (season == Season.Spring)
            {
                Console.WriteLine("spring march to may");
            }
            else if (season == Season.Summer)
            {
                Console.WriteLine("summer june to august");
            }
            else if (season == Season.Autumn)
            {
                Console.WriteLine("autumn September to November");
            }
            else if (season == Season.Winter)
            {
                Console.WriteLine("winter December to February");
            }


            #endregion

            #region Q4

            /*
             4. Assign the following Permissions (Read, write, Delete, Execute) in a form
                of Enum.
                Create Variable from previous Enum to Add and Remove Permission
                from variable, check if specific Permission is existed inside variable
            */

            Permissions permissions = Permissions.None ;

            permissions |= Permissions.Write; 

            if ((permissions & Permissions.Write) == Permissions.Write)
            {
                Console.WriteLine("write is existed");
            }
            else
            {
                Console.WriteLine("write is not existed");
            }

            permissions |= Permissions.Delete;

            if ((permissions & Permissions.Delete) == Permissions.Delete)
            {
                Console.WriteLine("delete is existed");
            }
            else
            {
                Console.WriteLine("delete is not existed");
            }

            Console.WriteLine($"permissions : {permissions}");







            #endregion

            #region Q5
            /*             
            5. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as
            its members. Write a C# program that takes a color name as input from
            the user and displays a message indicating whether the input color is a
            primary color or not
            */

            string str5;

            bool flag5;

            Colors color;

            do
            {
                Console.Write("Enter a string : ");
                str5 = Console.ReadLine();
                flag5 = Enum.TryParse(str5, true, out color);
            } while (!flag5);

            if (color == Colors.Red || color == Colors.Blue || color == Colors.Green)
            {
                Console.WriteLine($"{color} is a primary color.");
            }
            else
            {
                Console.WriteLine($"{color} is not a primary color.");
            }

            #endregion

            #region Q6

            /*
             6. Create a struct called "Point" to represent a 2D point with properties "X"
                and "Y". Write a C# program that takes two points as input from the user
                and calculates the distance between them.
            */

            Point point1, point2;
            double x1, y1, x2, y2;
            double distance;


            do
            {
                Console.Write("Enter the X coordinate of the first point: ");
            } while (!double.TryParse(Console.ReadLine(), out x1));

            do
            {
                Console.Write("Enter the Y coordinate of the first point: ");
            } while (!double.TryParse(Console.ReadLine(), out y1));

            point1 = new Point(x1, y1);

            do
            {
                Console.Write("Enter the X coordinate of the second point: ");
            } while (!double.TryParse(Console.ReadLine(), out x2));

            do
            {
                Console.Write("Enter the Y coordinate of the second point: ");
            } while (!double.TryParse(Console.ReadLine(), out y2));

            point2 = new Point(x2, y2);

            distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));

            Console.WriteLine($"The distance between the two points is: {distance}");

            #endregion

            #region Q7

            /*
             7. Create a struct called "Person" with properties "Name" and "Age". Write a
                C# program that takes details of 3 persons as input from the user and
                displays the name and age of the oldest person.
            */
            Person[] p = new Person[3];

            for (int i = 0; i < p.Length; i++)
            {
                string name = Console.ReadLine();

                int age = int.Parse(Console.ReadLine());

                p[i] = new Person(name, age);
            }

            Person oldest = p[0];

            Console.WriteLine($"The oldest person is: {oldest.Name}, Age: {oldest.Age}");

            #endregion


        }
    }
}
