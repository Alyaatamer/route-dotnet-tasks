using Revision.Classes___objects;
using Revision.Constructor;
using Revision.Properities___Encapsulation;

namespace Revision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ClassCar
            // object (instance from class)
            Car c1 = new Car();
            c1.Model = "BWM";
            #endregion

            #region ConstructorHouse

          //  House h1 = new House(); //object creation //instantiation

                             //ctrl+shift+space
            House h2 = new House(10000);  
            
          //  Console.WriteLine(h2.price);

            House h3 = new House(5, "123 Main St");

            //House h4 = new House();
            //Console.WriteLine(h4.price);



            #endregion

            #region Access Modifier 

            // public   // can see outside the class
            // private  // can't see outside the class
            // protected // in inheritance
            // internal // can see in the same assembly

            #endregion

            #region ClassPerson

            Person p1 = new Person();
            p1.Name = "alyaa";
            Console.WriteLine(p1.Name);

            #endregion

        }
    }
}
