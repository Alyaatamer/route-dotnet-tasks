namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car c1 = new Car();

            //Console.WriteLine(c1);

            //Car c2 = new Car("BMW",CarColors.Black, CarType.Electricity);
            //Console.WriteLine(c2);

            //c2 = new("BYD");
            //Console.WriteLine(c2);


            //c2 = new("Kia", CarColors.Green);
            //Console.WriteLine(c2);

            #region inheritance 

            parent p = new parent(10,20);

            Console.WriteLine(p.product());

            child c = new child(1,2,3);

            Console.WriteLine(c.product());

          //  Console.WriteLine(c.print());    //error 

            #endregion



        }
    }
}
