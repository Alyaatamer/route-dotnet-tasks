using System.Linq.Expressions;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Fraction & Discard

            float x = 1.2345678888888f; // 7 digits after .

           // Console.WriteLine(x);

            // int y = 12345678987654323456;  // error (overflow)

            double y = 1.12345678987654321;
            //  Console.WriteLine(y);

            decimal z = 1.12345677432256765m;
            // Console.WriteLine(z);

            //------------------------Discard------------------------

            long num = 100_000_000_000_000_000;
            // Console.WriteLine(num);

            // Console.WriteLine($"{num:c}");


            #endregion

            #region Casting

            // value to references 
            // references to value
            // value to value
            // references to references


            // value to value 
            // implicit => safe casting 
            // explicit => unsafe casting 

            //implicit casting
            int a = 5; // 4byte
            long b = a; // 8byte

            //explicit casting 
            long c = 12345678987654321;
            // int d = c; error => (overflow)

            int d = (int)c;

            //checked
            //{
            //    long e = 12345678987654321;
            //    int r = (int)e;

            //    unchecked
            //    {
            //        Console.WriteLine(r);
            //    }

            //}


            //-------------------------Error Handling------------------------
            long t = 123456789;
            int w = 0;

            if (int.MaxValue >= t)
            {
                w = (int)t;
               // Console.WriteLine(w);
            }
            else
            {
               // Console.WriteLine("Something wrong!");
            }


            #endregion

            #region Casting Methods 

            //  string? name = Console.ReadLine();
            // int age1 = Convert.ToInt32(Console.ReadLine());

            //  int age2 = int.Parse(Console.ReadLine());

            // bool flag = int.TryParse(Console.ReadLine(), out int age);
            //Console.WriteLine(age);
            //Console.WriteLine(flag);

            //  bool flag2 = decimal.TryParse(Console.ReadLine(), out decimal salary);
            //Console.WriteLine(salary);
            //Console.WriteLine(flag2);



            #endregion

            #region Operator

            //unary 
            int cnt = 5;
            cnt++;
            cnt--;
            //Console.WriteLine(cnt++);
            //Console.WriteLine(cnt);
            //Console.WriteLine(++cnt);

            //binary 
            int num1=3 , num2=2 ;

            //Console.WriteLine(num1+num2);
            //Console.WriteLine(num1-num2);
            //Console.WriteLine(num1*num2);
            //Console.WriteLine(num1/num2);
            //Console.WriteLine(num1%num2);

            //assigment
            num1 += 1;
            num2 -= 1;
            num1 *= 1;
            num2 /= 1;
            num1 %= 1;

            //comparsion 

            //Console.WriteLine(num1==num2); 
            //Console.WriteLine(num1!=num2);
            //Console.WriteLine(num1>num2);
            //Console.WriteLine(num1<num2);
            //Console.WriteLine(num1>=num2);


            //logical 
            //Console.WriteLine(!true);
            //Console.WriteLine(true && true);
            //Console.WriteLine(true || false);

            //bitwise
            //Console.WriteLine(0101 & 0111);
            //Console.WriteLine(0101 | 0111);

            //ternary
            int cnt1 = 5 , cnt2 = 10;
            string massage = cnt1 > cnt2 ? "Cnt1>Cnt2" : "Cnt1<Cnt2";
            // Console.WriteLine(massage);
            #endregion

            #region String Format 
            //Equation : 4 + 6 = 10
            int a1 = 4;
            int a2 = 6;

            //string concat 
            string show_massage = "Equation : " + a1 + " + " + a2 + " = " + a1 + a2;
            // Console.WriteLine(show_massage);

            //Equation:
            //Equation:4
            //Equation:4+
            //Equation:4+6
            //Equation:4+6=
            //Equation:4+6=10


            //format
            string new_massage = string.Format("Equation : {0} + {1} = {2}" , a1,a2,a1+a2);
           // Console.WriteLine(new_massage);

            //string interpolation $
            string _new = $"Equation : {a1} + {a2} = {a1 + a2}";
            // Console.WriteLine(_new);

            // => \t   \n  \\   
            string path = "F:\\route-dotnet-tasks\\C#"; //@    //$



            #endregion

            #region conditional statements 

            if (true)
            {
                // Console.WriteLine(true);
            }
            else
            {
                // Console.WriteLine(false);
            }

            int check = 5;
            switch (check)
            {
                case 1:
                  //  Console.WriteLine("1 is true"); 
                    break;
                case 2:
                  //  Console.WriteLine("2 is true");
                    break;
                case 3:
                   // Console.WriteLine("3 is true");
                    break;
                default:
                   // Console.WriteLine("something wrong");
                    break;
            }




            #endregion
        }
    }
}
