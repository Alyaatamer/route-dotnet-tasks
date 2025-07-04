using System.Threading.Channels;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array

            //reference type
            //stack (ref) =>4 byte  heap(object)

            //array
            //. same type
            //. fixed size
            //. undexing 




            #endregion

            #region 1D Array 

            int[] numbers;
            //references at stack => 4 byte (NULL)

            numbers = new int[3];
            // CLR Allocate at Heap ( 4*3 ) => 12 Bytes

            // Console.WriteLine(numbers.GetType().Name);


            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;

            //Console.WriteLine(numbers[2]);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    bool flag;
            //    do
            //    {
            //        Console.WriteLine($"Enter the number {i+1} = ");
            //        flag = int.TryParse( Console.ReadLine(), out numbers[i] );
            //    }while (!flag);
            //}

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}



            #region Arrays Declaration Ways

            int[] num1 = new int[3];
            int[] num2 = new int[3] { 1, 2, 3 };
            int[] num3 = { 1, 2, 3, 4 };

            #endregion


            #endregion

            #region 2D Array

            int[,] marks = new int[3, 5];

            //Console.WriteLine(marks.Rank);
            //Console.WriteLine(marks.GetLength(0)); 

            //for(int i = 0; i < marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter the marks of student {i+1} : ");
            //    Console.WriteLine("=================================================");
            //    for(int j = 0; j<marks.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter the mark of subject {j+1} : ");
            //        bool flag;
            //        do
            //        {
            //            flag = int.TryParse(Console.ReadLine() , out marks[i,j]);
            //        } while (!flag);

            //    }
            //}
            //Console.Clear();
            //for (int i = 0; i < marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"the marks of student {i + 1} : ");
            //    Console.WriteLine("=================================================");
            //    for (int j = 0; j < marks.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"the mark of subject {j + 1} : {marks[i,j]} ");
            //    }
            //}
            #endregion

            #region  Boxing && unBoxing

            //Casting
            // value to value
            // reference to reference (oop)
            //value to references (Boxing)
            // reference to value (UnBoxing)

            //bahaivor should to avoid


            #region Boxing
            int x = 5; //stack
            object obj = x; //reference type 
            #endregion

            #region UnBoxing
            object nums = new int[5] { 1, 2, 3, 4, 5 };
            int y = (int)nums;  //unBoxing 
            #endregion

            #endregion

        }
    }
}
