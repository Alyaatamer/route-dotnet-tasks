using System.Collections;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee[] employees =
            //{
            //    new Employee(1,"Alyaa",100000),
            //    new Employee(2,"Alia",8000),
            //    new Employee(3,"Alyiaa",7000),
            //    new Employee(4,"Aliaa",6000),
            //    new Employee(5,"Alya",50000),
            //};

            //Employee emp = new Employee(5, "Alya", 50000);
           // Console.WriteLine(Helper<Employee>.LinearSearch(employees, emp));



            //============================================
            //collections

            //generic collections -->list
            // non generic collections -->Arraylist

            //Arraylist  => dynamic
            //Array => static (Fixed size)

            ArrayList arrayList = new ArrayList(); // object

            arrayList.Add(1); // boxing (value type --> reference type)

           // Console.WriteLine(arrayList[0]); //unboxing (object --> value type)

            arrayList.Add("Alyaa");
            arrayList.Remove("Alyaa");
            arrayList.Add(2.5);
            arrayList.RemoveAt(arrayList.Count - 1); // remove last item

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }


            //=====================================
            //list 

            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);


        }
    }
}
