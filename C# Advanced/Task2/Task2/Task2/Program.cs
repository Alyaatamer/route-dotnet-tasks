using System.Collections;
using System.Collections.Generic;

namespace Task2
{
    internal class Program
    {
        #region Q1
        public static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void BubbleSort(int[] arr)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            swap(ref arr[j], ref arr[j + 1]);
                        }
                    }
                }
            }
        }
        #endregion

        #region Q2

        public static void ReverseArray(ArrayList arr)
        {
            if(arr is not null)
            {
                for (int i = 0; i < arr.Count / 2; i++)
                {
                    object temp = arr[i];
                    arr[i] = arr[arr.Count - 1 - i];
                    arr[arr.Count - 1 - i] = temp;
                }
            }
        }
        #endregion

        #region Q5
        public static void ReverseQueue(Queue<int> queue)
        {
            if (queue is not null)
            {
                Stack<int> stack = new Stack<int>();
                while (queue.Count > 0)
                {
                    stack.Push(queue.Dequeue());
                }
                while (stack.Count > 0)
                {
                    queue.Enqueue(stack.Pop());
                }
            }
        }
        #endregion

        #region Q10

        public static void SearchInStack(Stack<int>stack, int target)
        {
            int count = 0;
            bool found = false;

            while (stack.Count > 0)
            {
                count++;
                int value = stack.Pop();
                if (value == target)
                {
                    found = true;
                    Console.WriteLine($"Target was found successfully and the count = {count}");
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Target was not found");
            }
        }

        #endregion

        #region Q13

        public static void ReverseFirstK(Queue<int> queue, int k)
        {
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < k; i++)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            int remaining = queue.Count - k;
            for (int i = 0; i < remaining; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
        }

        #endregion
        static void Main(string[] args)
        {
            #region Q1
            int[] arr = { 5, 3, 8, 4, 2 };
            BubbleSort(arr);
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            #endregion

            #region Q2
            ArrayList a = new ArrayList();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter element {i + 1}:");
                int num;
                bool flag = int.TryParse(Console.ReadLine(), out num);
                if (flag)
                {
                    a.Add(num);
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter an integer.");
                    i--;
                }
            }
            ReverseArray(a);
            foreach (int num in a)
            {
                Console.Write(num + " ");
            }

            #endregion

            #region Q3

            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int q = int.Parse(input[1]);

            //----------------------
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter element {i + 1}:");
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Invalid input, please enter an integer.");
                }
            }
            //-----------------
            while (q > 0)
            {
                Console.WriteLine("Enter a number to count elements greater than it:");
                int number = int.Parse(Console.ReadLine());
                int result = Array.FindAll(array, x => x > number).Length;
                Console.WriteLine(result);
                q--;
            }


            #endregion

            #region Q4
            int size;

            while (true)
            {
                Console.WriteLine("Enter the size of the array:");
                if (int.TryParse(Console.ReadLine(), out size) && size > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a positive integer.");
                }
            }

            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter element {i + 1}:");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input, please enter an integer.");
                }
            }

            bool isPalindrome = true;
            for (int i = 0; i < size; i++)
            {
                if (numbers[i] == numbers[size - 1 - i])
                {
                    continue;
                }
                else
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            #endregion

            #region Q5

            Console.WriteLine("Enter the number of elements in the queue:");
            int queueSize;
            while (!int.TryParse(Console.ReadLine(), out queueSize) || queueSize <= 0)
            {
                Console.WriteLine("Invalid input, please enter a positive integer.");
            }
            Queue<int> queue = new Queue<int>(queueSize);
            for (int i = 0; i < queueSize; i++)
            {
                Console.WriteLine($"Enter the element {i + 1} of the queue:");
                int element;
                while (!int.TryParse(Console.ReadLine(), out element))
                {
                    Console.WriteLine("Invalid input, please enter an integer.");
                }
                queue.Enqueue(element);
            }

            ReverseQueue(queue);
            for (int i = 0; i < queueSize; i++)
            {
                Console.Write(queue.Dequeue() + " ");
            }


            #endregion

            #region Q6

            string str = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            bool check = true;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(' || str[i] == '{' || str[i] == '[')
                {
                    stack.Push(str[i]);
                }
                else if (str[i] == ')')
                {
                    if (stack.Count == 0 || stack.Peek() != '(')
                    {
                        check = false;
                        break;
                    }
                    stack.Pop();
                }
                else if (str[i] == '}')
                {
                    if (stack.Count == 0 || stack.Peek() != '{')
                    {
                        check = false;
                        break;
                    }
                    stack.Pop();
                }
                else if (str[i] == ']')
                {
                    if (stack.Count == 0 || stack.Peek() != '[')
                    {
                        check = false;
                        break;
                    }
                    stack.Pop();
                }
            }
            if (check && stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }


            #endregion

            #region Q7

            int SizeArray;
            while (true)
            {
                Console.WriteLine("Enter the size of the array:");
                if (int.TryParse(Console.ReadLine(), out SizeArray) && SizeArray > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a positive integer.");
                }
            }

            int[] removeduplicate = new int[SizeArray];
            for (int i = 0; i < SizeArray; i++)
            {
                Console.WriteLine($"Enter element {i + 1}:");
                while (!int.TryParse(Console.ReadLine(), out removeduplicate[i]))
                {
                    Console.WriteLine("Invalid input, please enter an integer.");
                }
            }

            removeduplicate = removeduplicate.Distinct().ToArray();
            Console.WriteLine("Array after removing duplicates:");
            foreach (int num in removeduplicate)
            {
                Console.Write(num + " ");
            }



            #endregion

            #region Q8
            int SizeList;
            while (true)
            {
                Console.WriteLine("Enter the size of the list:");
                if (int.TryParse(Console.ReadLine(), out SizeList) && SizeList > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a positive integer.");
                }
            }

            List<int> list = new List<int>(SizeList);
            for (int i = 0; i < SizeList; i++)
            {
                int element;
                Console.WriteLine($"Enter element {i + 1}:");
                while (!int.TryParse(Console.ReadLine(), out element))
                {
                    Console.WriteLine("Invalid input, please enter an integer.");
                }
                list.Add(element);
            }
            list.RemoveAll(x => x % 2 != 0);

            foreach (int num in list)
            {
                Console.Write(num + " ");
            }

            #endregion

            #region Q9

            Queue<object> queu = new Queue<object>();

            queu.Enqueue(1);
            queu.Enqueue("Apple");
            queu.Enqueue(5.28);

            foreach (var item in queu)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Q10

            int sz;
            while (true)
            {
                Console.WriteLine("Enter the size of the stack:");
                if (int.TryParse(Console.ReadLine(), out sz) && sz > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a positive integer.");
                }
            }
            Stack<int> st = new Stack<int>(sz);

            for (int i = 0; i < sz; i++)
            {
                int element;
                Console.WriteLine($"Enter element {i + 1}:");
                while (!int.TryParse(Console.ReadLine(), out element))
                {
                    Console.WriteLine("Invalid input, please enter an integer.");
                }
                st.Push(element);
            }

            Console.WriteLine("Enter the target number to search in the stack:");
            int target;
            while (!int.TryParse(Console.ReadLine(), out target))
            {
                Console.WriteLine("Invalid input, please enter an integer.");
            }

            SearchInStack(st, target);

            #endregion

            #region 11

            int size1, size2;

            while (true)
            {
                Console.WriteLine("Enter the size of the first array:");
                if (int.TryParse(Console.ReadLine(), out size1) && size1 > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a positive integer.");
                }
            }

            while (true)
            {
                Console.WriteLine("Enter the size of the second array:");
                if (int.TryParse(Console.ReadLine(), out size2) && size2 > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a positive integer.");
                }
            }

            int[] arr1 = new int[size1];
            for (int i = 0; i < size1; i++)
            {
                Console.WriteLine($"Enter element {i + 1} of the first array:");
                while (!int.TryParse(Console.ReadLine(), out arr1[i]))
                {
                    Console.WriteLine("Invalid input, please enter an integer.");
                }
            }

            int[] arr2 = new int[size2];
            for (int i = 0; i < size2; i++)
            {
                Console.WriteLine($"Enter element {i + 1} of the second array:");
                while (!int.TryParse(Console.ReadLine(), out arr2[i]))
                {
                    Console.WriteLine("Invalid input, please enter an integer.");
                }
            }


            Dictionary<int, int> freq = new Dictionary<int, int>();
            foreach (int num in arr1)
            {
                if (freq.ContainsKey(num))
                    freq[num]++;
                else
                    freq[num] = 1;
            }

            List<int> intersection = new List<int>();
            foreach (int num in arr2)
            {
                if (freq.ContainsKey(num) && freq[num] > 0)
                {
                    intersection.Add(num);
                    freq[num]--;
                }
            }

            for (int i = 0; i < intersection.Count; i++)
            {
                Console.Write(intersection[i] + " ");
            }

            #endregion

            #region 12

            ArrayList arry = new ArrayList();

            Console.Write("Enter the size of the array: ");
            int siz = int.Parse(Console.ReadLine());


            for (int i = 0; i < siz; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                int num;
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Invalid input, please enter an integer:");
                }
                arry.Add(num);
            }

            Console.Write("Enter target sum: ");
            int targetSum = int.Parse(Console.ReadLine());

            int start = 0;
            int currentSum = 0;
            bool found = false;

            for (int end = 0; end < arry.Count; end++)
            {
                currentSum += (int)arry[end];

                while (currentSum > targetSum && start < end)
                {
                    currentSum -= (int)arry[start];
                    start++;
                }

                if (currentSum == targetSum)
                {
                    Console.Write("[");
                    for (int i = start; i <= end; i++)
                    {
                        Console.Write(arry[i]);
                        if (i < end) Console.Write(", ");
                    }
                    Console.WriteLine("]");
                    found = true;
                    break;
                }
            }

            if (!found)
                Console.WriteLine("No sublist found");

            #endregion

            #region Q13

            Queue<int> qu = new Queue<int>();

            Console.Write("Enter the size of the queue: ");
            int sizeOfQu = int.Parse(Console.ReadLine());

            for (int i = 0; i < sizeOfQu; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                int num;
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Invalid input, please enter an integer:");
                }
                qu.Enqueue(num);
            }

            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());

            if (k > 0 && k <= qu.Count)
            {
                ReverseFirstK(qu, k);

                Console.WriteLine("Output: [" + string.Join(", ", qu) + "]");
            }
            else
            {
                Console.WriteLine("Invalid K value.");
            }

            #endregion
        }
    }
}
