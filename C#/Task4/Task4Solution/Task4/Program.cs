namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Example 1
            /*
             1- Write a program in C# Sharp to find the sum of all elements of the
                array.
            */
            int size1;
            bool flag1;

            do
            {
                Console.Write("Enter the size of the array: ");
                flag1 = int.TryParse(Console.ReadLine(), out size1);
            } while (!flag1 || size1 <= 0);


            int[] numbers1 = new int[size1];

            int cnt1 = 0, sum = 0;
            do
            {
                Console.Write($"Enter the element {cnt1 + 1} : ");
                flag1 = int.TryParse(Console.ReadLine(), out numbers1[cnt1]);
                cnt1++;
            } while (!flag1 || !(cnt1 > size1 - 1));

            for (int i = 0; i < size1; i++)
            {
                sum += numbers1[i];
            }
            Console.WriteLine($"The sum of all elements of the array is : {sum}");

            #endregion

            #region Example 2
            /*
             2- Write a program in C# Sharp to merge two arrays of the same size sorted
                    in ascending order.
            */
            int size2;
            bool flag2;

            do
            {
                Console.Write("Enter the size of the arrays: ");
                flag2 = int.TryParse(Console.ReadLine(), out size2);
            } while (!flag2 || size2 <= 0);

            int[] arr1 = new int[size2];
            int[] arr2 = new int[size2];

            int[] mergedArr = new int[size2 * 2];

            int cnt2 = 0;
            do
            {
                Console.Write($"Enter the element {cnt2 + 1} of the first array: ");
                flag2 = int.TryParse(Console.ReadLine(), out arr1[cnt2]);
                cnt2++;
            } while (!flag2 || !(cnt2 > size2 - 1));

            cnt2 = 0;
            do
            {
                Console.Write($"Enter the element {cnt2 + 1} of the second array: ");
                flag2 = int.TryParse(Console.ReadLine(), out arr2[cnt2]);
                cnt2++;
            } while (!flag2 || !(cnt2 > size2 - 1));


            for (int i = 0; i < size2; i++)
            {
                mergedArr[i] = arr1[i];
                mergedArr[i + size2] = arr2[i];
            }

            Array.Sort(mergedArr);

            foreach (int num in mergedArr)
            {
                Console.Write(num + " ");
            }

            #endregion

            #region Example 3
            /*
             3- Write a program in C# Sharp to count the frequency of each element of
                    an array.
            */
            int size3;
            bool flag3;

            do
            {
                Console.Write("Enter the size of the array: ");
                flag3 = int.TryParse(Console.ReadLine(), out size3);
            } while (!flag3 || size3 <= 0);

            int[] numbers3 = new int[size3];
            int cnt3 = 0;

            do
            {
                Console.Write($"Enter the element {cnt3 + 1} : ");
                flag3 = int.TryParse(Console.ReadLine(), out numbers3[cnt3]);
                cnt3++;
            } while (!flag3 || !(cnt3 > size3 - 1));


            int[] frequency = new int[size3+5];

            for (int i = 0; i < size3; i++)
            {
                frequency[numbers3[i]]++;
            }

            for (int i = 0; i < size3; i++)
            {
                Console.WriteLine($"frequency of element {numbers3[i]} = {frequency[numbers3[i]]}");
            }


            #endregion

            #region Example 12
            /*
             12- Write a program in C# Sharp to find maximum and minimum element in an
                    array
            */
            int size12;
            bool flag12;

            do
            {
                Console.Write("Enter the size of the array: ");
                flag12 = int.TryParse(Console.ReadLine(), out size12);
            } while (!flag12 || size12 <= 0);


            int[] numbers12 = new int[size12];
            int cnt12 = 0;
            do
            {
                Console.Write($"Enter the element {cnt12 + 1} : ");
                flag12 = int.TryParse(Console.ReadLine(), out numbers12[cnt12]);
                cnt12++;
            } while (!flag12 || !(cnt12 > size12 - 1));

            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < size12; i++)
            {
                if (numbers12[i] > max)
                {
                    max = numbers12[i];
                }
                if (numbers12[i] < min)
                {
                    min = numbers12[i];
                }
            }
            Console.WriteLine($"Maximum element in the array is: {max}");
            Console.WriteLine($"Minimum element in the array is: {min}");

            #endregion

            #region Example 4
            /*
             4- Write a program in C# Sharp to find the second largest element in an
                    array.
            */
            int size4;
            bool flag4;

            do
            {
                Console.Write("Enter the size of the array: ");
                flag4 = int.TryParse(Console.ReadLine(), out size4);
            } while (!flag4 || size4 <= 1);

            int[] numbers4 = new int[size4];
            int cnt4 = 0;
            do
            {
                Console.Write($"Enter the element {cnt4 + 1} : ");
                flag4 = int.TryParse(Console.ReadLine(), out numbers4[cnt4]);
                cnt4++;
            } while (!flag4 || !(cnt4 > size4 - 1));

            Array.Sort(numbers4);
            int secondLargest = numbers4[size4 - 2];
            Console.WriteLine($"The second largest element in the array is: {secondLargest}");
            #endregion

            #region Example 5
            /*
             write a program find the longest distance between Two equal cells. In this example. The
                distance is measured by the number Of cells- for example, the distance between the first and
                the fourth cell is 2 (cell 2 and cell 3).
            */

            int size5;
            bool flag5;

            do
            {
                Console.Write("Enter the size of the array: ");
                flag5 = int.TryParse(Console.ReadLine(), out size5);
            } while (!flag5 || size5 <= 0);

            int[] numbers5 = new int[size5];
            int cnt5 = 0;

            do
            {
                Console.Write($"Enter the element {cnt5 + 1} : ");
                flag5 = int.TryParse(Console.ReadLine(), out numbers5[cnt5]);
                cnt5++;
            } while (!flag5 || !(cnt5 > size5 - 1));

            int LongestDistance = 0;
            for (int i = 0; i < size5; i++)
            {
                for (int j = i + 1; j < size5; j++)
                {
                    if (numbers5[i] == numbers5[j])
                    {
                        int distance = j - i - 1;
                        if (distance > LongestDistance)
                        {
                            LongestDistance = distance;
                        }
                    }
                }
            }
            Console.WriteLine($"The longest distance between two equal cells is: {LongestDistance}");


            #endregion

            #region Example 6
            /*
             6- Given a list of space separated words, reverse the order of the words.
            */
            string word;
            bool flag6;

            do
            {
                Console.Write("Enter words: ");
                word = Console.ReadLine();
                flag6 = !string.IsNullOrWhiteSpace(word);
            } while (!flag6);

            string result = "", test = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                {
                    result = ' ' + test + result;
                    test = "";
                }
                else
                {
                    test += word[i];
                }
            }
            result = test + result;

            Console.WriteLine($"The Result = {result}");


            // using Split Function
            Console.WriteLine("=================================");
            string[] words = word.Split(' ');
            Array.Reverse(words);
            string reversedWords = string.Join(" ", words);
            Console.WriteLine($"Reversed words using Split: {reversedWords}");


            #endregion

            #region Example 7
            /*
             7- Write a program to create two multidimensional arrays of same size.
                Accept value from user and store them in first array. Now copy all the
                elements of first array on second array and print second array.
            */

            int rows, cols;
            bool flag7;

            do
            {
                Console.Write("Enter the number of rows: ");
                flag7 = int.TryParse(Console.ReadLine(), out rows);
            } while (!flag7 || rows <= 0);

            do
            {
                Console.Write("Enter the number of columns: ");
                flag7 = int.TryParse(Console.ReadLine(), out cols);
            } while (!flag7 || cols <= 0);

            int[,] firstArray = new int[rows, cols];
            int[,] secondArray = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter the element at position [{i}, {j}]: ");
                    flag7 = int.TryParse(Console.ReadLine(), out firstArray[i, j]);
                    if (!flag7)
                    {
                        Console.Write($"Enter the element at position [{i}, {j}]: ");
                        j--;
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    secondArray[i, j] = firstArray[i, j];
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(secondArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            #endregion

            #region Example 8
            /*
             8- Write a Program to Print One Dimensional Array in Reverse Order
            */
            int size;
            bool flag;

            do
            {
                Console.Write("Enter the size of the array: ");
                flag = int.TryParse(Console.ReadLine(), out size);
            } while (!flag || size <= 0);

            int[] numbers = new int[size];
            int cnt = 0;
            do
            {
                Console.Write($"Enter the element {cnt + 1} : ");
                flag = int.TryParse(Console.ReadLine(), out numbers[cnt]);
                cnt++;
            } while (!flag || !(cnt > size - 1));

            for (int i = size - 1; i >= 0; i--)
            {
                Console.WriteLine($"Element at index {i} is: {numbers[i]}");
            }

            // OR
            Console.WriteLine("========================");
            Array.Reverse(numbers);

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Element at index {i} is: {numbers[i]}");
            }
            #endregion
        }
    }
}
