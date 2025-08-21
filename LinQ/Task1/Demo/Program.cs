namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10};

            var oddnumbers = Enumerable.Where(Numbers , x => x % 2 == 1);

            //foreach (var number in oddnumbers)
            //{
            //    Console.WriteLine(number);
            //}

            oddnumbers = from N in Numbers where N % 2 == 1 select N;
            //foreach (var number in oddnumbers)
            //{
            //    Console.WriteLine(number);
            //}


        }
    }
}
