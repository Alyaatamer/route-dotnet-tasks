namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Example 1
            /*
             1- Write a program that takes a number from the user then print yes if that
                number can be divided by 3 and 4 otherwise print no.  */

            bool flag1;
            int num1;

            do
            {
                Console.WriteLine("Enter the Number: ");
                flag1 = int.TryParse(Console.ReadLine(), out num1);

                if (num1 % 3 == 0 && num1 % 4 == 0)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            } while (!flag1);
            #endregion

            #region Example 2
            /*
             2- Write a program that allows the user to insert an integer then print
                negative if it is negative number otherwise print positive
            */
            bool flag2;
            int num2;

            do
            {
                Console.WriteLine("Enter the Number: ");
                flag2 = int.TryParse(Console.ReadLine(), out num2);

                if (num2 < 0)
                {
                    Console.WriteLine("negative");
                }
                else
                {
                    Console.WriteLine("positive");
                }
            } while (!flag2);

            #endregion

            #region Example 3
            /*
             3- Write a program that takes 3 integers from the user then prints the max
                   element and the min element.
             */

            int[] numbers = new int[3];
            bool flag3;
            int max = int.MinValue;
            int min = int.MaxValue;

            int i = 0;
            do
            {
                Console.WriteLine("Enter the Number: ");
                flag3 = int.TryParse(Console.ReadLine(), out numbers[i]);
                if (flag3)
                {
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }
                    i++;
                }
            } while (!flag3 || i < 3);

            Console.WriteLine($"max element = : {max}");
            Console.WriteLine($"min element = : {min}");

            #endregion

            #region Example 4
            /*
              4- Write a program that allows the user to insert an integer number then
                    check If a number is even or odd.
            */
            bool flag4;
            int num4;

            do
            {
                Console.WriteLine("Enter the Number: ");
                flag4 = int.TryParse(Console.ReadLine(), out num4);

                if (flag4)
                {
                    if (num4 % 2 == 0)
                    {
                        Console.WriteLine("Even");
                    }
                    else
                    {
                        Console.WriteLine("Odd");
                    }
                }
            } while (!flag4);

            #endregion

            #region Example 5
            /*
             5- Write a program that takes character from the user then if it is a vowel
                chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            */
            bool flag5;
            char c1;

            do
            {
                Console.WriteLine("Enter character : ");
                flag5 = char.TryParse(Console.ReadLine(), out c1);
                c1 = char.ToLower(c1);

                if (flag5 && (c1 >= 'a' && c1 <= 'z'))
                {
                    if ("aeiou".Contains(char.ToLower(c1))) //contains is a method that checks if the string contains the specified character
                    {
                        Console.WriteLine("vowel");
                    }
                    else
                    {
                        Console.WriteLine("consonant");
                    }
                }
            } while (!flag5 || !(c1 >= 'a' && c1 <= 'z'));

            #endregion

            #region Example 6
            /*
             6- Write a program that allows the user to insert an integer then print all
                numbers between 1 to that number.
            */
            bool flag6;
            int num6;

            do
            {
                Console.WriteLine("Enter the Number: ");
                flag6 = int.TryParse(Console.ReadLine(), out num6);
                if (flag6 && num6 > 0)
                {
                    for (i = 1; i <= num6; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
            } while (!flag6 || !(num6 > 0));
            #endregion

            #region Example 7

            /*
             7- Write a program that allows the user to insert an integer then
                 print a multiplication table up to 12.
             */

            bool flag7;
            int num7;

            do
            {
                Console.WriteLine("Enter the Number: ");
                flag7 = int.TryParse(Console.ReadLine(), out num7);
                if (flag7)
                {
                    for (i = 1; i <= 12; i++)
                    {
                        Console.WriteLine($"{num7} * {i} = {num7 * i}");
                    }
                }
            } while (!flag7);
            #endregion

            #region Example 8
            /*
             8- Write a program that allows to user to insert number then print all even
                numbers between 1 to this number
            */
            bool flag8;
            int num8;

            do
            {
                Console.WriteLine("Enter the Number: ");
                flag8 = int.TryParse(Console.ReadLine(), out num8);
                if (flag8 && num8 > 0)
                {
                    for (i = 1; i <= num8; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            } while (!flag8 || !(num8 > 0));
            #endregion

            #region Example 9
            /*
             9- Write a program that takes two integers then prints the power.
            */
            bool flag9;
            int baseNum, exponent;

            do
            {
                Console.WriteLine("Enter the base number: ");
                flag9 = int.TryParse(Console.ReadLine(), out baseNum);
                if (flag9)
                {
                    Console.WriteLine("Enter the exponent number: ");
                    flag9 = int.TryParse(Console.ReadLine(), out exponent);
                    if (flag9)
                    {
                        int result = 1;
                        for (i = 0; i < exponent; i++)
                        {
                            result *= baseNum;
                        }
                        Console.WriteLine($"{baseNum} ^ {exponent} = {result}");
                    }
                }
            } while (!flag9);
            #endregion

            #region Example 10
            /*
             10- Write a program to enter marks of five subjects and calculate total,
                    average and percentage.
            */
            bool flag10;
            double[] marks = new double[5];
            double total = 0;
            double avarage;
            double percentage;

             i = 0;
            do
            {
                Console.WriteLine("Enter the marks for subject " + (i + 1) + ": ");
                flag10 = double.TryParse(Console.ReadLine(), out marks[i]);
                if (flag10 && marks[i] >= 0 && marks[i] <= 100)
                {
                    total += marks[i];
                    i++;
                }
                else
                {
                    Console.WriteLine("Please enter a valid mark between 0 and 100.");
                }
            } while (!flag10 || i < 5);

            avarage = total / 5;
            percentage = (total / 500) * 100;

            Console.WriteLine($"Total marks = {total}");
            Console.WriteLine($"Average Marks  = {avarage}");
            Console.WriteLine($"Percentage = {percentage}%");
            #endregion

            #region Example 11
            /*
             11- Write a program to input the month number and print the number of days in
                  that month.
            */
            bool flag11;
            int month;

            do
            {
                Console.WriteLine("Enter the month number (1-12): ");
                flag11 = int.TryParse(Console.ReadLine(), out month);
                if (flag11 && month >= 1 && month <= 12)
                {
                    switch (month)
                    {
                        case 1: // January
                        case 3: // March
                        case 5: // May
                        case 7: // July
                        case 8: // August
                        case 10: // October
                        case 12: // December
                            Console.WriteLine("31 days");
                            break;
                        case 4: // April
                        case 6: // June
                        case 9: // September
                        case 11: // November
                            Console.WriteLine("30 days");
                            break;
                        case 2: // February
                            Console.WriteLine("28 or 29 days (29 in leap years)");
                            break;
                    }
                }
            } while (!flag11 || !(month >= 1 && month <= 12));

            #endregion

            #region Example 12
            /*
             12- Write a program to create a Simple Calculator.
            */
            bool flag12;
            double n1, n2;
            char operation;

            do
            {
                Console.WriteLine("Enter the first number: ");
                flag12 = double.TryParse(Console.ReadLine(), out n1);
                if (flag12)
                {
                    Console.WriteLine("Enter the second number: ");
                    flag12 = double.TryParse(Console.ReadLine(), out n2);
                    if (flag12)
                    {
                        Console.WriteLine("Enter the operation (+, -, *, /): ");
                        operation = char.Parse(Console.ReadLine());
                        switch (operation)
                        {
                            case '+':
                                Console.WriteLine($"Result: {n1 + n2}");
                                break;
                            case '-':
                                Console.WriteLine($"Result: {n1 - n2}");
                                break;
                            case '*':
                                Console.WriteLine($"Result: {n1 * n2}");
                                break;
                            case '/':
                                if (num2 != 0)
                                    Console.WriteLine($"Result: {n1 / n2}");
                                else
                                    Console.WriteLine("Error: Division by zero is not allowed.");
                                break;
                            default:
                                Console.WriteLine("Invalid operation. Please enter +, -, *, or /.");
                                break;
                        }
                    }
                }
            } while (!flag12);
            #endregion

            #region Example 13
            /*
             13- Write a program to allow the user to enter a string and print the REVERSE
                    of it.
            */
            bool flag13;
            string str;

            do
            {
                Console.WriteLine("Enter String = ");
                flag13 = !string.IsNullOrEmpty(str = Console.ReadLine());
                if (flag13)
                {
                    char[] chararcters = str.ToCharArray();
                    Array.Reverse(chararcters);
                    Console.WriteLine("Reversed String: " + new string(chararcters));
                }
                else
                {
                    Console.WriteLine("Please enter a valid string.");
                }
            } while (!flag13);

            #endregion

            #region Example 14
            /*
             14- Write a program to allow the user to enter int and print the REVERSED of
                  it.
            */
            bool flag14;
            int num14;

            do
            {
                Console.WriteLine("Enter the Number : ");
                flag14 = int.TryParse(Console.ReadLine(), out num14);
                if (flag14)
                {
                    string Num = num14.ToString();
                    string ReversedNum = "";
                    for (i = Num.Length - 1; i >= 0; i--)
                    {
                        ReversedNum += Num[i];
                    }
                    Console.WriteLine($"Reversed Number = {ReversedNum}");
                }
            } while (!flag14);
            #endregion

            #region Example 15
            /*
             15- Write a program in C# Sharp to find prime numbers within a range of
                   numbers.
            */
            bool flag15;
            int start = 0;
            int end = 0;

            do
            {
                Console.WriteLine("Enter the start number of the range: ");
                flag15 = int.TryParse(Console.ReadLine(), out start);
                if (flag15 && start > 0)
                {
                    Console.WriteLine("Enter the end number of the range: ");
                    flag15 = int.TryParse(Console.ReadLine(), out end);
                    if (flag15 && start <= end)
                    {
                        Console.WriteLine($"The prime number between {start} and {end} are : ");
                        for (i = start; i <= end; i++)
                        {
                            bool check = true;

                            if (i == 1)
                            {
                                check = false;
                            }
                            for (int j = 2; j <= i; j++)
                            {
                                if (i % j == 0 && j != i)
                                {
                                    check = false;
                                    break;
                                }
                            }
                            if (check)
                            {
                                Console.WriteLine(i);
                            }
                        }
                    }
                }
            } while (!flag15 || !(start <= end));

            #endregion

            #region Example 16
            /*
             16- . Write a program in C# Sharp to convert a decimal number into binary
                    without using an array.
            */
            bool flag16;
            int num16;

            do
            {
                Console.WriteLine("Enter a number to convert : ");
                flag16 = int.TryParse(Console.ReadLine(), out num16);
                if (flag16)
                {
                    string res = "";
                    while (num16 > 0)
                    {
                        int remainder = num16 % 2;
                        if (remainder == 0)
                        {
                            res = "0" + res;
                        }
                        else
                        {
                            res = "1" + res;
                        }
                        num16 = num16 / 2;
                    }
                    Console.WriteLine($"The Binary of {num16} is {res}");
                }

            } while (!flag16);

            #endregion

            #region Example 17
            /*
             17- Create a program that asks the user to input three points (x1, y1), (x2,
                y2), and (x3, y3), and determines whether these points lie on a single
                straight line.
            */
            bool flag17;
            double x1 = 0.0, y1 = 0.0, x2 = 0.0, y2 = 0.0, x3 = 0.0, y3 = 0.0;

            do
            {
                Console.WriteLine("Enter x1 : ");
                flag17 = double.TryParse(Console.ReadLine(), out x1);
                if (flag17)
                {
                    Console.WriteLine("Enter y1 : ");
                    flag17 = double.TryParse(Console.ReadLine(), out y1);
                    if (flag17)
                    {
                        Console.WriteLine("Enter x2 : ");
                        flag17 = double.TryParse(Console.ReadLine(), out x2);
                        if (flag17)
                        {
                            Console.WriteLine("Enter y2 : ");
                            flag17 = double.TryParse(Console.ReadLine(), out y2);
                            if (flag17)
                            {
                                Console.WriteLine("Enter x3 : ");
                                flag17 = double.TryParse(Console.ReadLine(), out x3);
                                if (flag17)
                                {
                                    Console.WriteLine("Enter y3 : ");
                                    flag17 = double.TryParse(Console.ReadLine(), out y3);
                                    if (flag17)
                                    {
                                        double slope1 = (y2 - y1) / (x2 - x1);
                                        double slope2 = (y3 - y2) / (x3 - x2);
                                        if (slope1 == slope2)
                                        {
                                            Console.WriteLine("The points lie on a single straight line.");
                                        }
                                        else
                                        {
                                            Console.WriteLine("The points do not lie on a single straight line.");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            } while (!flag17);


            #endregion

            #region Example 18

            /*
             18- Within a company, the efficiency of workers is evaluated based on the
                duration required to complete a specific task. A worker's efficiency level is
                determined as follows:
                - If the worker completes the job within 2 to 3 hours, they are considered
                highly efficient.
                - If the worker takes 3 to 4 hours, they are instructed to increase their
                speed.
                - If the worker takes 4 to 5 hours, they are provided with training to
                enhance their speed.
                - If the worker takes more than 5 hours, they are required to leave the
                company.
                To calculate the efficiency of a worker, the time taken for the task is
                obtained via user input from the keyboard.

            */

            bool flag18;
            Console.WriteLine("Enter Size of Array");
            int size;
            flag18 = int.TryParse(Console.ReadLine(), out size);
            int[] workers = new int[size];

            for (i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter the time taken by worker {i + 1} in hours: ");
                flag18 = int.TryParse(Console.ReadLine(), out workers[i]);
                if (flag18)
                {
                    if (workers[i] >= 0 && workers[i] <= 3)
                    {
                        Console.WriteLine("considered highly efficient.");
                    }
                    else if (workers[i] > 3 && workers[i] <= 4)
                    {
                        Console.WriteLine("instructed to increase their speed.");
                    }
                    else if (workers[i] > 4 && workers[i] <= 5)
                    {
                        Console.WriteLine("provided with training to enhance their speed.");
                    }
                    else if (workers[i] > 5)
                    {
                        Console.WriteLine("required to leave the company");
                    }
                }
            }

            #endregion

            #region Example 19

            /*
             19- . Write a program that prints an identity matrix using for loop, in other
                    words takes a value n from the user and shows the identity table of size n * n.
            */

            int n;
            Console.WriteLine("Enter size of matrix : ");
            bool flag19 = int.TryParse(Console.ReadLine(), out n);

            for (i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"i = {i}  ,  j = {j}");
                }
            }


            #endregion

            #region Example 20
            /*
             20-What will be the output of the C# code given below?
            int num = 1, z = 5;
            if (!(num <= 0))
             Console.WriteLine( ++num + z++ + " " + ++z );
            else
             Console.WriteLine( --num + z-- + " " + --z );
            */

            // if (!(num <= 0)) // num is 1, so [!(1 <= 0) = (1 > 0)] is true
            //num = 2 , z = 5 , z = 6 , z = 7

            // Console.WriteLine(2 + 5 + " " + 7); // output: 7 7
            #endregion
        }
    }
}
