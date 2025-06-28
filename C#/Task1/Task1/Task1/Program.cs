using System.ComponentModel;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Example 1

            // 1- Write a program that allows the user to enter a number then print it.
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(x);

            #endregion

            #region Example 2

            /*
            2 - Write C# program that Assigning one value type variable
                to another and modifying the value of one variable and
                mention what will happen
            */
                int num1 = 10;
                int num2 = 20;

                Console.WriteLine($"Before change: num1 = {num1}, num2 = {num2}"); // num1 = 10, num2 = 20

                num1 = num2; // num1 = 20 (change) , num2 = 20 (not change)

                Console.WriteLine($"After change : num1 = {num1}, num2 = {num2}"); // num1 = 20, num2 = 20

                num2 = 30; // num1 = 20 (not change)  , num2 = 30 (change)

                Console.WriteLine($"After change : num1 = {num1}, num2 = {num2}"); // num1 = 20, num2 = 30

               // num1 will not change because value types are copied by value not by reference

            #endregion

            #region Example 3
            /*
            3 - Write C# program that Assigning one reference type
                variable to another and modifying the object through
                one variable and mention what will happen
            */

            Human h1 = new Human();
            Human h2 = new Human();

            h1.name = "Alyaa";
            h1.age = 20;

            h2.name = "Ali";
            h2.age = 20;


            Console.WriteLine($"before change h1: {h1.GetHashCode()} , h2: {h2.GetHashCode()}"); // h1: 43942917 , h2: 59941933

            h1 = h2; // h1 now points to the same object as h2

            Console.WriteLine($"after change h1: {h1.GetHashCode()} , h2: {h2.GetHashCode()}"); // h1: 59941933 , h2: 59941933

            h1.name = "Tamer"; // changing the name of h1 will also change h2 because they point to the same object

            #endregion
        }
    }
}
