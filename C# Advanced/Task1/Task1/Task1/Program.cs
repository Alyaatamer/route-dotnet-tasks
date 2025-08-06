namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            int start = 0, end = 0;
            bool flag;

            do
            {
                Console.WriteLine("Enter start and end of range (start < end):");
                flag = int.TryParse(Console.ReadLine(), out start) &&
                       int.TryParse(Console.ReadLine(), out end) &&
                       start < end;
            } while (!flag);


            Range<int> r1 = new Range<int>(start, end);

            Console.WriteLine($"Length : {r1.Length()}");
            Console.WriteLine($"Is {5} In Range ? {r1.IsInRange(5)}");
            Console.WriteLine($"Is {11} In Range ? {r1.IsInRange(11)}");

            Console.WriteLine($"min : {r1.min}\nmax : {r1.max}");
            #endregion



            #region Q2

            List<int> numbers = new List<int>();

            int size;
            bool flag2;
            do
            {
                Console.Write("Enter a size : ");
                flag2 = int.TryParse(Console.ReadLine(), out size);
            } while (!flag2);

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter a number : ");
                int currentNumber = int.Parse(Console.ReadLine());
                numbers.Add(currentNumber);
            }

            List<int> evenNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                }
            }
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            #endregion


            #region Q3

            FixedSizeList<int> List = new FixedSizeList<int>(2);

            List.Add(1);
            List.Add(2);
            // List.Add(3); // This will throw an exception because the list is full

            Console.WriteLine(List.Get(0)); // Output: 1
            Console.WriteLine(List.Get(1)); // Output: 2
            // Console.WriteLine(List.Get(2)); // This will throw an exception because the index is out of range


            #endregion


            #region Q4

            Console.Write("Enter String: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input is empty or null.");
            }
            else
            {
                Dictionary<char, int> freq = new Dictionary<char, int>();
                for (int i = 0; i < input.Length ; i++)
                {
                    if (freq.ContainsKey(input[i]))
                    {
                        freq[input[i]]++;
                    }
                    else freq[input[i]] = 1;
                }

                bool hasNonRepeated = false;
                int res = -1;
                for (int i = 0; i < input.Length; i++)
                {
                    if (freq[input[i]]==1)
                    {
                        res = i;
                        hasNonRepeated = true;
                    }
                }
                if(hasNonRepeated)
                {
                    Console.WriteLine($"First non-repeated character : {input[res]} in index {res}");
                }
                else
                {
                    Console.WriteLine(res);
                    Console.WriteLine("There is no non-repeated character in the string.");
                }
            }

            #endregion




        }
    }
}
