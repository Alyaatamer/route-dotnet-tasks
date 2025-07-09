namespace Quiz
{
    internal class Program
    {
        #region Q1

        static void customerNames(string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        #endregion

        #region Q3

        static void check(int num)
        {
            if (num%2==0)
            {
                Console.WriteLine("The Number Is Even");
            }
            else
            {
                Console.WriteLine("The Number Is Odd");
            }
        }
        #endregion

        #region Q4

        static void convert(double temp)
        {
            double res = (9 / 5) * temp + 32;
            Console.WriteLine(res);
        }

        #endregion

        #region Q5
        static double avg(double num1, double num2)
        {
            double avg = num1 + num2;
            return avg / 2;
        }

        #endregion

        #region Q6

        static void sumofdigits(string str)
        {
            int sum = 0;
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    sum += c - '0'; 
                }
            }
            Console.WriteLine($"The sum of digits in the string is: {sum}");
        }

        #endregion

        #region Q8

        static bool IsPali(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                    return false;
            }
            return true;
        }

        #endregion
        static void Main(string[] args)
        {
            #region Q1
            /*
             1. Write a function that takes an array of customer names and prints each name
                    using a foreach loop
            */

            int size;
            bool flag1;

            do
            {
                Console.Write("Enter the number of customers:");
                flag1 = int.TryParse(Console.ReadLine(), out size);
            } while (!flag1);

            string[] customerNamesArray = new string[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter customer name {i + 1}: ");
                customerNamesArray[i] = Console.ReadLine();
            }

            customerNames(customerNamesArray);

            #endregion

            #region Q2

            /*
             2. Write a program that defines an array of employee names and print the name
                    with the most characters. 
            */

            int size2;
            bool flag2;

            do
            {
                Console.Write("Enter the number of employees: ");
                flag2 = int.TryParse(Console.ReadLine(), out size2);
            } while (!flag2);

            string[] employeeNames = new string[size2];

            for (int i = 0; i < size2; i++)
            {
                Console.Write($"Enter employee name {i + 1}: ");
                employeeNames[i] = Console.ReadLine();
            }

            string res = "";
            int maxLength = 0;
            foreach (string name in employeeNames)
            {
                if (name.Length > maxLength)
                {
                    maxLength = name.Length;
                    res = name;
                }
            }
            Console.WriteLine($"The employee with the most characters is: {res} with {maxLength} characters.");

            #endregion

            #region Q3

            /*
            3.Write a C# function that take integer number and check that this number is
                Even or Odd?            
            */
            int num;
            bool flag3;

            do
            {
                Console.Write("Enter an integer number: ");
                flag3 = int.TryParse(Console.ReadLine(), out num);
            } while (!flag3);

            check(num);

            #endregion

            #region Q4

            /*
             4.Write a C# function that converts a temperature from Celsius to Fahrenheit
                using the formula:
                F = (9/5) x C + 32
            */
            double celsius;
            bool flag4;

            do
            {
                Console.Write("Enter temperature in Celsius: ");
                flag4 = double.TryParse(Console.ReadLine(), out celsius);
            } while (!flag4);

            convert(celsius);


            #endregion

            #region Q5
            /*
             5. Write a C# function that accepts two decimal numbers representing order
                    amounts and returns their average.
            */
            double num1, num2;
            bool flag5;

            do
            {
                Console.Write("Enter the first decimal number: ");
                flag5 = double.TryParse(Console.ReadLine(), out num1);
            } while (!flag5);

            do
            {
                Console.Write("Enter the second decimal number: ");
                flag5 = double.TryParse(Console.ReadLine(), out num2);
            } while (!flag5);


            double average = avg(num1, num2);
            Console.WriteLine($"The average of {num1} and {num2} is: {average}");

            #endregion

            #region Q6
            /*
             6. Write a function that takes a string containing both letters and digits, and
                    returns the sum of all digits in the string.
            */

            string s;
            bool flag6;

            do
            {
                Console.Write("Enter a string containing letters and digits: ");
                s = Console.ReadLine();
                flag6 = !string.IsNullOrEmpty(s);
            } while (!flag6);


            sumofdigits(s);
            #endregion

            #region Q7

            /*
             7.What is the Difference between Boxing and UnBoxing?                     
            */
            //boxing converts a value type to a reference type.
            //unboxing extracts the value type from the reference type.

            #endregion

            #region Q8
            /*
             8. Write a C# program that checks whether a given string is a palindrome or not. A
                palindrome is a word that reads the same forward and backward (e.g., "madam",
                "racecar"). Use a for loop to compare characters from both ends and optimize the
                loop to avoid unnecessary comparisons
            */
            string str;
            bool flag8;

            do
            {
                Console.Write("Enter a string to check if it's a palindrome: ");
                str = Console.ReadLine();
                flag8 = !string.IsNullOrEmpty(str);
            } while (!flag8);

            if (IsPali(str))
            {
                Console.WriteLine($"{str} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{str} is not a palindrome.");
            }
            #endregion

            #region Q9

            /*
             9. Write a program in C# Sharp to find the sum of all elements of the array.
            */
            int size9;
            bool flag9;

            do
            {
                Console.Write("Enter the number of elements in the array: ");
                flag9 = int.TryParse(Console.ReadLine(), out size9);
            } while (!flag9);

            int[] arr = new int[size9];

            for (int i = 0; i < size9; i++)
            {
                bool flagElement;
                do
                {
                    Console.Write($"Enter element {i + 1}: ");
                    flagElement = int.TryParse(Console.ReadLine(), out arr[i]);
                } while (!flagElement);
            }

            int sum = 0;
            foreach (int element in arr)
            {
                sum += element;
            }
            Console.WriteLine($"The sum of all elements in the array is: {sum}");

            #endregion

            #region Q10

            /*
             10. Write a program that allows to user to insert number then print all even numbers
                    between 1 to this number
            */
            int num10;
            bool flag10;

            do
            {
                Console.Write("Enter a positive integer: ");
                flag10 = int.TryParse(Console.ReadLine(), out num10) && num10 > 0;
            } while (!flag10);

            for (int i = 1; i <= num10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion
        }
    }
}
