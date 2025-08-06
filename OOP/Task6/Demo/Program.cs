namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility u = new Utility(3.14);

            Console.WriteLine(Utility.MeterToCm(50));

            Console.WriteLine(Utility.CalcCirleArea(4));
        }
    }
}
