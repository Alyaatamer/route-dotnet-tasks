namespace Demo
{
    internal class Program
    {
        public static void method(Shapes s)
        {
            if (s != null)
            {
                Console.WriteLine(s.CalcArea());
                Console.WriteLine(s.parameter);
            }
        }
        static void Main(string[] args)
        {
            //Employee[] employees =
            //{
            //    new Employee(2,"omar",20000),
            //    new Employee(1,"Alyaa",10000),
            //    new Employee(3,"Amr",30000),
            //    new Employee(4,"Soher",40000),
            //};

            //Array.Sort(employees);

            //foreach(var emp in employees)
            //{
            //    Console.WriteLine(emp);
            //    Console.WriteLine("=============================");
            //}


            Rectangler r = new Rectangler();
            r.Dim01 = 10;
            r.Dim02 = 10;
            Console.WriteLine(r.CalcArea());

            Console.WriteLine("=============================");
        }
    }
}
