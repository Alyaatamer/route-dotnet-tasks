using ASSLINQ;
using System.Runtime.Intrinsics.Arm;
using System.Threading;
using static ASSLINQ.ListGenerators;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LINQ - Restriction Operators

            #region 1
            var result = ProductList.Where(n => n.UnitsInStock == 0);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region 2
            var result2 = ProductList.Where(n => n.UnitsInStock > 0 && n.UnitPrice > 3);

            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region 3
            String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var result3 = Arr.Select((name, index) => new { Name = name, Value = index }).Where(n => n.Name.Length < n.Value);

            foreach (var item in result3)
            {
                Console.WriteLine(item);
            }
            #endregion

            #endregion

            #region LINQ - Element Operators

            #region 1

            var result4 = ProductList.FirstOrDefault(n => n.UnitsInStock == 0);

            if (result4 != null)
            {
                Console.WriteLine(result4);
            }
            else
            {
                Console.WriteLine("No product with zero stock found.");
            }

            #endregion

            #region 2

            var result5 = ProductList.FirstOrDefault(n => n.UnitPrice > 1000);

            if (result5 != null)
            {
                Console.WriteLine(result5);
            }
            else
            {
                Console.WriteLine("No product with price greater than 1000 found.");
            }

            #endregion

            #region 3

            int[] Array = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result6 = Array.Where(n => n > 5).Skip(1).First();

            Console.WriteLine(result6);

            #endregion

            #endregion

            #region LINQ - Aggregate Operators

            #region 1

            int[] ar = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var result7 = ar.Count(n => n % 2 == 1);
            Console.WriteLine(result7);

            #endregion

            #region 2

            var result8 = CustomerList.Select(n => new { Name = n.CustomerName, Count = n.Orders.Count() });

            foreach (var item in result8)
            {
                Console.WriteLine($"{item.Name} has {item.Count} orders.");
            }
            #endregion

            #region 3

            var result9 = ProductList.GroupBy(g => g.Category).Select(g => new { Category = g.Key, Count = g.Count() });

            foreach (var item in result9)
            {
                Console.WriteLine($"{item.Category} has {item.Count} products.");
            }

            #endregion

            #region 4

            int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var result10 = arr.Sum();
            Console.WriteLine($"Total sum of elements: {result10}");

            #endregion

            #region 5

            string[] str = File.ReadAllLines("dictionary_english.txt");

            int Total = str.Sum(n => n.Length);

            Console.WriteLine($"Total number of characters in the dictionary: {Total}");

            #endregion

            #region 6

            int min = str.Min(n => n.Length);

            Console.WriteLine($"Minimum length of a word in the dictionary: {min}");

            #endregion

            #region 7

            int max = str.Max(n => n.Length);
            Console.WriteLine($"Maximum length of a word in the dictionary: {max}");

            #endregion

            #region 8

            double average = str.Average(n => n.Length);
            Console.WriteLine($"Average length of a word in the dictionary: {average}");

            #endregion

            #endregion

            #region LINQ - Ordering Operators

            #region 1

            var result11 = ProductList.OrderBy(n => n.ProductName).ToList();

            foreach (var item in result11)
            {
                Console.WriteLine(item);
            }


            #endregion

            #region 2

            String[] strings = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var result12 = strings.OrderBy(n => n, StringComparer.OrdinalIgnoreCase).ToList();

            foreach (var item in result12)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region 3

            var result13 = ProductList.OrderByDescending(n => n.UnitsInStock);

            foreach (var item in result13)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region 4

            string[] numbers = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            var result14 = numbers.OrderBy(n => n.Length).ThenBy(n => n);

            foreach (var item in result14)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region 5

            var result15 = strings.OrderBy(n => n.Length).ThenBy(n => n, StringComparer.OrdinalIgnoreCase);
            foreach (var item in result15)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region 6

            var result16 = ProductList.OrderBy(n => n.Category).ThenByDescending(n => n.UnitPrice);

            foreach (var item in result16)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region 7

            var result17 = strings.OrderBy(n => n.Length).ThenByDescending(n => n, StringComparer.OrdinalIgnoreCase);
            foreach (var item in result17)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region 8

            var result18 = numbers.Where(n => n.Length > 1 && n[1] == 'i').Reverse();

            foreach (var item in result18)
            {
                Console.WriteLine(item);
            }

            #endregion

            #endregion

            #region LINQ – Transformation Operators

            #region 1

            var result19 = ProductList.Select(n => n.ProductName);

            foreach (var item in result19)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region 2

            String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            var result20 = words.Select(n => new { lower = n.ToLower(), upper = n.ToUpper() });

            foreach (var item in result20)
            {
                Console.WriteLine($"Lower: {item.lower}, Upper: {item.upper}");
            }

            #endregion

            #region 3

            var result21 = ProductList.Select(n => new { Name = n.ProductName, price = n.UnitPrice });
            foreach (var item in result21)
            {
                Console.WriteLine($"Name: {item.Name}, Price: {item.price}");
            }

            #endregion

            #region 4

            int[] nums = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var result22 = nums.Select((value, index) => new { Value = value, Index = index });

            Console.WriteLine("Numbers : In place?");
            foreach (var item in result22)
            {
                if (item.Value == item.Index)
                {
                    Console.WriteLine($"{item.Value} : True");
                }
                else
                {
                    Console.WriteLine($"{item.Value} : False");
                }
            }
            #endregion

            #region 5

            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            Console.WriteLine("Pairs where A < B:");
            var result23 = from a in numbersA
                           from b in numbersB
                           where a < b
                           select new { A = a, B = b };

            foreach (var item in result23)
            {
                Console.WriteLine($"A: {item.A}, B: {item.B}");
            }


            #endregion

            #region 6

            var result24 = from c in CustomerList
                           from o in c.Orders
                           where o.Total < 500
                           select new
                           {
                               Name = c.CustomerName,
                               OrderID = o.OrderID,
                               Total = o.Total
                           };

            foreach (var item in result24)
            {
                Console.WriteLine($"{item.Name} => Order {item.OrderID}, Total {item.Total}");
            }

            #endregion

            #region 7

            var result25 = from c in CustomerList
                           from o in c.Orders
                           where o.OrderDate.Year >= 1998
                           select new
                           {
                               Name = c.CustomerName,
                               OrderID = o.OrderID,
                               Date = o.OrderDate
                           };

            foreach (var item in result25)
            {
                Console.WriteLine($"{item.Name} => Order {item.OrderID}, Date {item.Date.ToShortDateString()}");
            }

            #endregion

            #endregion
        }
    }
}
