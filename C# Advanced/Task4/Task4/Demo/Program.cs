namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            compareDelegate<int> compareDelegate = CompareClass.CompareSmaller;
            int[] numbers = { 2, 1, 5, 3, 4, 7, 6 };

            SortingAlgorithms<int>.BubbleSort(numbers, compareDelegate);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            compareDelegate<string> compareStringDelegate = CompareClass.CompareStringgreater;
            string[] names = { "Alyaa", "Soher", "Engy", "Mariam", "Ali" };

            SortingAlgorithms<string>.BubbleSort(names, compareStringDelegate);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
