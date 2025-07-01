using System.Text;
using System.Xml;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Control Statements(looping statements)
            #region For loop

            //for (int i = 1; i <= 10; i++) //32 step
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region collection looping

            //int[] numbers = {1,2,3,4,5}; //20 byte 

            //for (int i = 0; i<numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region foreach 

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region while - do while 

            //int i = 1;
            //while (i<=10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //bool flag;
            //int num;

            //do
            //{
            //    Console.WriteLine("enter even number");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //} while (!flag || num%2==1);

            #endregion

            #endregion

            #region String Vs String Builder 

            //string name = "Eslam";
            //Console.WriteLine(name.GetHashCode());

            //name = "Omar";
            //Console.WriteLine(name.GetHashCode());

            //string name2 = "Omar";
            //Console.WriteLine(name2.GetHashCode());

            //Console.WriteLine(name==name2); // true 

            //string name1 = "Ahmed";
            //string name2 = "Yasmmine";
            //Console.WriteLine(name1.GetHashCode());
            //Console.WriteLine(name2.GetHashCode());

            //Console.WriteLine("-----------------------------------");

            //name1 = name2;
            //Console.WriteLine(name1.GetHashCode());
            //Console.WriteLine(name2.GetHashCode());

            #endregion

            #region String Methods

            string massage = "    Hello Route    ";
            // Console.WriteLine(massage.Trim());
            //Console.WriteLine(massage.TrimEnd());
            //Console.WriteLine(massage.TrimStart());
            //Console.WriteLine(massage.ToLower());
            //Console.WriteLine(massage.Trim().ToLower());
            // Console.WriteLine(massage.Trim().Substring(0,5));
            // Console.WriteLine(massage.Replace("H","T"));
            // Console.WriteLine(massage.Insert(0,"HI"));
            // Console.WriteLine(massage.Remove(0,5));

            #endregion

            #region String Builder

            //linked list 

            //StringBuilder name1 = new StringBuilder();
            //StringBuilder name2 = new StringBuilder();
            //Console.WriteLine(name1);
            //Console.WriteLine(name2);
            //Console.WriteLine("-------------------------------------");
            //name2 = name1;
            //Console.WriteLine(name1);
            //Console.WriteLine(name2);
            //Console.WriteLine("-------------------------------------");





            #endregion

            #region Task

            //string name = "Hello Route";

            //for (int i=0;i<name.Length;i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        string s = name[i].ToString();
            //        Console.Write(s.ToLower());
            //    }
            //    else
            //    {
            //        string s = name[i].ToString();
            //        Console.Write(s.ToUpper());
            //    }
            //}

            //Console.WriteLine("");
            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}
           
            #endregion
        }
    }
}
