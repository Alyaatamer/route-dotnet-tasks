namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Example 1
            /*  1 - Write a program that allows the user to enter a
                    number then print it.   */
            bool flag = int.TryParse(Console.ReadLine(), out int number);

            if (flag && number != 0)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("0");
            }
            #endregion

            #region Example 2

            /*   2- Write C# program that converts a string to an
                    integer, but the string contains non-numeric
                    characters. And mention what will happen       */

            // we can't convert directly because string contains non_numeric characters, it will throw an exception
            string? str = Console.ReadLine();
            try
            {
                int num = Convert.ToInt32(str);
                Console.WriteLine(num);
            }
            catch (FormatException)
            {
                Console.WriteLine("The string contains non-numeric characters and cannot be converted to an integer.");
            }

            #endregion

            #region Example 3
            /*   3 - Write C# program that Perform a simple arithmetic
                    operation with floating-point numbers And mention
                    what will happen           */

            float num1 = 1234.123421f;
            float num2 = 12.1378256f;
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            Console.WriteLine($"{num1} % {num2} = {num1 % num2}");

            #endregion

            #region Example 4
            /*   4 - Write C# program that Extract a substring from a
                     given string. (Search)    */

            string? s1 = Console.ReadLine();

            string s2 = s1.Substring(0, 5);

            Console.WriteLine(s2);


            #endregion

            #region Example 5

            /* 5 - Write C# program that take two string variables and
                     print them as one variable  */

            string? first = Console.ReadLine();
            string? second = Console.ReadLine();

            string result = first + second;

            Console.WriteLine(result);

            #endregion

            #region Example 6

            /*   6 - Write a program that calculates the simple interest
                       given the principal amount, rate of interest, and
                       time.The formula for simple interest is
                       Interest = (principal * rate * time) / 100.         */

            double principal = Convert.ToDouble(Console.ReadLine());
            double rate = Convert.ToDouble(Console.ReadLine());
            double time = Convert.ToDouble(Console.ReadLine());

            double Interest = (principal * rate * time) / 100;
            Console.WriteLine(Interest);
            #endregion

            #region Example 7

            /*
            7 - Write a program that calculates the Body Mass Index
                (BMI) given a person's weight in kilograms and height
                in meters.The formula for BMI is
                BMI = (Weight) / (Height * Height)
            */

            double weight = Convert.ToDouble(Console.ReadLine());
            double height = Convert.ToDouble(Console.ReadLine());

            double BMI = weight / (height * height);

            Console.WriteLine(BMI);

            #endregion

            #region Example 8
            /*
            8 - Write a program that takes the date from the user and
                displays it in various formats using string
                interpolation. (Search)
                Ex:
                    Today’s date : 20 , 11 , 2001
                    Today's date : 20 / 11 / 2001
                    Today's date : 20 – 11 – 2001     */

            int day = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Today's date : {day} , {month} , {year}");
            Console.WriteLine($"Today's date : {day} / {month} / {year}");
            Console.WriteLine($"Today's date : {day} - {month} - {year}");

            #endregion

            #region Example 9
            /*
            9- What is the output of the following C# code?
             (Search) 
            DateTime date = new DateTime(2024, 6, 14);
            Console.WriteLine($"The event is on {date:MM/dd/yyyy}"); 
                a) The event is on 14/06/2024
                b) The event is on 2024-06-14
                c) The event is on 06/14/2024
                d) The event is on June 14, 2024   */

            DateTime date = new DateTime(2024, 6, 14);
            Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
            //   =>  c) The event is on 06/14/2024
            //                          MM DD YYYY 



            #endregion

            #region Example 10
            /*
            10 - Which of the following statements is correct
                 about the C#.NET code snippet given below?     
                    int d;
                    d = Convert.ToInt32( !(30 < 20) );

                e) A value 0 will be assigned to d.
                f) A value 1 will be assigned to d.
                g) A value -1 will be assigned to d.
                h) The code reports an error.
                i) The code snippet will work correctly if ! is replaced by Not.
             */

            int d;
            d = Convert.ToInt32(!(30 < 20));
            //                 (!( false )) = true => 1
            Console.WriteLine(d);
            // => f) A value 1 will be assigned to d.

            #endregion

            #region Example 11
            /*
            11 - Which of the following is the correct output for
                    the C# code given below? 
            Console.WriteLine(13 / 2 + " " + 13 % 2);
                    a) 6.5 1
                    b) 6.5 0
                    c) 6 0
                    d) 6 1
                    e) 6.5 6.5
            */

            Console.WriteLine(13 / 2 + " " + 13 % 2);
            // 6.5  1

            // => a) 6.5 1
            #endregion
        }
    }
}
