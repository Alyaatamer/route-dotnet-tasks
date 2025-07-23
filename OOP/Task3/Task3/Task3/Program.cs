using System.Xml;
using Task3.First_Project;
using Task3.Second_Project;
using Task3.Third_Project;
using static Task3.First_Project.Points;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project

            int x1, y1, z1, x2, y2, z2;
            bool flag1;

            do
            {
                Console.Write("Enter x1 : ");
                flag1 = int.TryParse(Console.ReadLine(), out x1);
            } while (!flag1);
            do
            {
                Console.Write("Enter y1 : ");
                flag1 = int.TryParse(Console.ReadLine(), out y1);
            } while (!flag1);
            do
            {
                Console.Write("Enter z1 : ");
                flag1 = int.TryParse(Console.ReadLine(), out z1);
            } while (!flag1);
            do
            {
                Console.Write("Enter x2 : ");
                flag1 = int.TryParse(Console.ReadLine(), out x2);
            } while (!flag1);
            do
            {
                Console.Write("Enter y2 : ");
                flag1 = int.TryParse(Console.ReadLine(), out y2);
            } while (!flag1);
            do
            {
                Console.Write("Enter z2 : ");
                flag1 = int.TryParse(Console.ReadLine(), out z2);
            } while (!flag1);

            Points P1 = new Points(x1, y1, z1);
            Points P2 = new Points(x2, y2, z2);

            Console.WriteLine(P1.ToString());
            Console.WriteLine(P2.ToString());

            if (P1 == P2)
            {
                Console.WriteLine("The points are equal.");
            }
            else
            {
                Console.WriteLine("The points are not equal.");
            }

            Points[] points = {
                new Points(1, 2, 3),
                new Points(2, 1, 6),
                new Points(2, 0, 9),               
            };

            Array.Sort(points, new ReversePointComparer());

            
            //foreach (var p in points)
            //{
            //    Console.WriteLine(p);
            //}

            #endregion

            #region Second Project

            int x, y;
            bool flag2;

            do
            {
                Console.Write("Enter x : ");
                flag2 = int.TryParse(Console.ReadLine(), out x);
            } while (!flag2);

            do
            {
                Console.Write("Enter y : ");
                flag2 = int.TryParse(Console.ReadLine(), out y);
            } while (!flag2);

            Console.WriteLine($"x + y = {Maths.Add(x, y)}");
            Console.WriteLine($"x - y = {Maths.Subtract(x, y)}");
            Console.WriteLine($"x * y = {Maths.Multiply(x, y)}");
            Console.WriteLine($"x / y = {Maths.Divide(x, y)}");

            #endregion

            #region Third Project

            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1);

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2); 

            Duration D3 = new Duration(7800);
             Console.WriteLine(D3);

            Duration D4 = new Duration(666);
             Console.WriteLine(D4); 

            Console.WriteLine(D3);
            Console.WriteLine(D1);
            Console.WriteLine(D2);
            D3 = D1 + D2;
            Console.WriteLine(D3);

            D3 = D1 + 7800;
            Console.WriteLine(D3);

            D3 = 666 + D3;
            Console.WriteLine(D3);

            D3 = ++D1;
            Console.WriteLine(D3);

            D3 = --D2;
            Console.WriteLine(D3);

            D1 = D1 - D2;
            Console.WriteLine(D1);

            if (D1 > D2)
            {
                Console.WriteLine("D1 > D2");
            }
            if (D1 <= D2)
            {
                Console.WriteLine("D1<=D2");
            }
            if (D1)
            {
                Console.WriteLine("D1 is true");
            }

            DateTime Obj = (DateTime)D1;
            Console.WriteLine(Obj.ToString("HH:mm:ss"));

            #endregion
        }
    }
}
