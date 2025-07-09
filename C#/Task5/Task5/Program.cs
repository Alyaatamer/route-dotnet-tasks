using System;

namespace Task5
{
    internal class Program
    {
        #region Example 1

        #region Pass by Value

        static void passbyvalue(int x)
        {
            x = 1 ;
            Console.WriteLine($"In : x = {x}");
        }

        #endregion

        #region pass by ref

        static void PassByRef(ref int a, ref int b)
        {
            a += b ;
            b = 1;
            Console.WriteLine($"IN : a = {a} , b = {b}");
        }

        #endregion

        #endregion

        #region Example 2

        #region Reference Type Param
        #region Passing by Value
        static int SumArray(int[] FunArray)
        {
            int sum = 0;

            if (FunArray is not null)
            {
                FunArray[0] = 100;//Change 1st Element
                for (int i = 0; i < FunArray.Length; i++)
                {
                    sum += FunArray[i];//Sum = Sum + FunArray[i]
                }
            }

            return sum;
        }
        #endregion

        #region Passing By Ref
        static int SumArray(ref int[] FunArray)
        {
            int sum = 0;
            Console.WriteLine($"Fun Array :{FunArray.GetHashCode()}");

            if (FunArray is not null)
            {
                FunArray = new int[5] { 100, 200, 300, 400, 500 };//Change 1st Element
                Console.WriteLine($"Fun Array :{FunArray.GetHashCode()}");

                for (int i = 0; i < FunArray.Length; i++)
                {
                    sum += FunArray[i];//Sum = Sum + FunArray[i]
                }
            }

            return sum;
        }
        #endregion


        #endregion

        #endregion

        #region Example 3

        static void sumsub(int x , int y , out int sum, out int sub)
        {
            sum = x + y;
            sub = x - y;
        }
        #endregion

        #region Example 4

        static int SumOfDigits(int num )
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        #endregion

        #region Example 5

        static bool isprime(int num)
        {
            for(int i = 2; i < Math.Sqrt(num); i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region Example 6

        static void MinMaxArray(int[] array , out int min , out int max)
        {
            min = int.MaxValue;
            max = int.MinValue;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] < min)
                {
                    min = array[i];
                }
                if(array[i] > max)
                {
                    max = array[i];
                }

            }
        }

        #endregion

        #region Example 7

        static int fac (int num)
        {
            int res = 1;
            for(int i = 1; i <= num; i++)
            {
                res *= i;
            }
            return res;
        }

        #endregion

        #region Example 8

        static string ChangeChar(string str, int pos, char c)
        {
            char[] chars = str.ToCharArray();
            chars[pos] = c;
            str = new string(chars);
            return str;
        }

        #endregion

        #region Example 9
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }


        #endregion
        static void Main(string[] args)
        {
            #region Example 1
            /*
             1)Explain the difference between passing (Value type parameters) by value and by
                reference then write a suitable c# example.
            */

            //pass by value (do not effect in original variable)
            //pass by ref (effect in original variable)

            #region Pass by value

            int x1 = 10;
            Console.WriteLine($"Before : x = {x1}");
            passbyvalue(x1);
            Console.WriteLine($"After : x = {x1}");

            #endregion

            #region pass by ref

            int a = 1;
            int b = 2;

            Console.WriteLine($"Before : a = {a} , b = {b}");
            PassByRef(ref a, ref b);
            Console.WriteLine($"After : a = {a} , b = {b}");

            #endregion



            #endregion

            #region Example 2

            /*
             2)Explain the difference between passing (Reference type parameters) by value and
                by reference then write a suitable c# example.
            */

            #region Reference Type Params
            int[] MainArray = { 1, 2, 3 };//6
                                          //MainArray => Reference
                                          // object At heap
                                          //FunArray = MainArray => 2 Reefe => 1 Object
                                          // Console.WriteLine(MainArray[0]);//1
            Console.WriteLine($"Main Array :{MainArray.GetHashCode()}");
            int Result = SumArray(ref MainArray);//Passing Value
            Console.WriteLine($"Main Array :{MainArray.GetHashCode()}");

            Console.WriteLine(MainArray[0]);//100

            Console.WriteLine(Result);//6
            #endregion


            #endregion

            #region Example 3

            /*
             3)Write a c# Function that accept 4 parameters from user and return result of
                summation and subtracting of two numbers
            */

            int x = 2, y = 1;
            int sum = 0, sub = 0;
            sumsub(x, y, out sum, out sub);
            Console.WriteLine($"sum = {sum} , sub = {sub}");
            #endregion

            #region Example 4

            /*
             4)Write a program in C# Sharp to create a function to calculate the sum of the
                   individual digits of a given number.
            */

            Console.WriteLine(SumOfDigits(25));

            #endregion

            #region Example 5

            /*
             5)Create a function named "IsPrime", which receives an integer number and returns
                true if it is prime, or false if it is not:
            */
             Console.WriteLine(isprime(7));

            #endregion

            #region Example 6

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int min = 0, max = 0;
            MinMaxArray(array, out min, out max);

            Console.WriteLine($"min = {min} , max = {max}");
            #endregion

            #region Example 7

            /*
             7)Create an iterative (non-recursive) function to calculate the factorial of the
                number specified as parameter
            */
            Console.WriteLine(fac(3));

            #endregion

            #region Example 8

            /*
             8)Create a function named "ChangeChar" to modify a letter in a certain position (0 based)
                of a string, replacing it with a different letter
            */
             Console.WriteLine(ChangeChar("Alyaa",0,'a'));


            #endregion

            #region Example 9

            /*
             9)Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as
                its members. Then, write a C# program that prints out all the days of the week using
                this enum.
            */

            string[] WeekDays = Enum.GetNames(typeof(WeekDays));

            for (int i = 0; i < WeekDays.Length; i++)
            {
                Console.WriteLine(WeekDays[i]);
            }
            #endregion




        }
    }
}
