using ASSLINQ;
using System.Collections.Generic;
using System.Linq;
using static ASSLINQ.ListGenerators;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Element Operators

            #region 1

            var res1 = ProductList.Where(n => n.UnitsInStock == 0).FirstOrDefault();
            //Console.WriteLine(res1 != null ? $"{res1.ProductName} is out of stock" : "All products are in stock");

            #endregion

            #region 2

            var res2 = ProductList.Where(n => n.UnitPrice > 1000).FirstOrDefault();
            //Console.WriteLine(res2 != null ? $"{res2.ProductName} costs more than 1000" : "No products cost more than 1000");

            #endregion

            #region 3

            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var res3 = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine(res3 != 0 ? $"{res3} is the second number greater than 5" : "There is no second number greater than 5");

            #endregion

            #endregion

            #region LINQ - Aggregate Operators

            #region 1

            var res4 = Arr.Where(n => n % 2 == 1).Count();
            //Console.WriteLine($"There are {res4} odd numbers in the array");

            #endregion

            #region 2

            var res5 = CustomerList.Select(n => new
            {
                CustomerID = n.CustomerID,
                OrderCount = n.Orders.Count()
            });

            //foreach (var customer in res5)
            //{
            //    Console.WriteLine($"Customer {customer.CustomerID} has {customer.OrderCount} orders");
            //}

            #endregion

            #region 3

            var res6 = ProductList.Select(n => new { cat = n.Category, prod_count = n.ProductName.Count() });
            //foreach (var item in res6)
            //{
            //    Console.WriteLine($"Category: {item.cat}, Product Count: {item.prod_count}");
            //}

            #endregion

            #region 4

            var res7 = Arr.Sum();
            //Console.WriteLine($"The sum of all numbers in the array is: {res7}");

            #endregion

            #region 5

            string[] strings = File.ReadAllLines("dictionary_english.txt");
            var res8 = strings.Sum(n => n.Length);
            //Console.WriteLine($"The total number of characters in the file is: {res8}");

            #endregion

            #region 6

            var res9 = strings.Min(n => n.Length);
            //Console.WriteLine($"Minimum length of a word in the dictionary: {res9}");

            #endregion

            #region 7

            var res10 = strings.Max(n => n.Length);
            //Console.WriteLine($"Maximum length of a word in the dictionary: {res10}");

            #endregion

            #region 8

            var res11 = strings.Average(n => n.Length);
            //Console.WriteLine($"Average length of words in the dictionary: {res11}");

            #endregion

            #region 9

            var res12 = ProductList.Select(n => new
            {
                cat = n.Category,
                Cnt = ProductList.Sum(n => n.UnitsInStock)
            });
            //foreach (var item in res12)
            //{
            //    Console.WriteLine($"Category: {item.cat}, Total Units in Stock: {item.Cnt}");
            //}

            #endregion

            #region 10

            var res13 = ProductList.Select(n => new
            {
                cat = n.Category,
                min = ProductList.Min(n => n.UnitPrice)
            });
            //foreach (var item in res13)
            //{
            //    Console.WriteLine($"Category: {item.cat}, Minimum Unit Price: {item.min}");
            //}

            #endregion

            #region 11

            var res14 = from p in ProductList
                        group p by p.Category into g
                        let minPrice = g.Min(x => x.UnitPrice)
                        from prod in g
                        where prod.UnitPrice == minPrice
                        select new
                        {
                            Category = g.Key,
                            Price = prod.UnitPrice
                        };

            //foreach (var item in res14)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Minimum Unit Price: {item.Price}");
            //}

            #endregion

            #region 12

            var res15 = ProductList.Select(n => new
            {

                cat = n.Category,
                max = ProductList.Max(n => n.UnitPrice)
            });

            //foreach (var item in res15)
            //{
            //    Console.WriteLine($"Category: {item.cat}, Maximum Unit Price: {item.max}");
            //}

            #endregion

            #region 13

            var res16 = from p in ProductList
                        group p by p.Category into g
                        let maxprice = g.Max(x => x.UnitPrice)
                        from prod in g
                        where prod.UnitPrice == maxprice
                        select new
                        {
                            Category = g.Key,
                            Price = prod.UnitPrice
                        };

            //foreach (var item in res16)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Maximum Unit Price: {item.Price}");
            //}

            #endregion

            #region 14

            var res17 = ProductList.Select(n => new
            {
                cat = n.Category,
                avg = ProductList.Average(n => n.UnitPrice)
            });

            //foreach (var item in res17)
            //{
            //    Console.WriteLine($"Category: {item.cat}, Average Unit Price: {item.avg}");
            //}

            #endregion

            #endregion

            #region LINQ - Set Operators

            #region 1

            var res18 = ProductList.Select(n => n.Category).Distinct();

            //foreach (var item in res18)
            //{
            //    Console.WriteLine($"Category: {item}");
            //}

            #endregion

            #region 2

            var res19 = ProductList.Select(p => p.ProductName[0]).Union(CustomerList.Select(c => c.CustomerName[0]));

            //foreach (var item in res19)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3

            var res20 = ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CustomerName[0]));

            //foreach (var item in res20)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 4

            var res21 = ProductList.Select(p => p.ProductName[0]).Except(CustomerList.Select(c => c.CustomerName[0]));

            //foreach (var item in res21)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 5

            var res22 = ProductList.Select(p => p.ProductName.Substring(p.ProductName.Length - 3)).Concat(CustomerList.Select(c => c.CustomerName.Substring(c.CustomerName.Length - 3)));

            //foreach (var item in res22)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region LINQ - Partitioning Operators

            #region 1

            var res23 = CustomerList.Where(c => c.City == "Washington").SelectMany(c => c.Orders).Take(3);

            //foreach (var order in res23)
            //{
            //    Console.WriteLine($"OrderID: {order.OrderID}, OrderDate: {order.OrderDate}, Total: {order.Total}");
            //}

            #endregion

            #region 2

            var res24 = CustomerList.Where(c => c.City == "Washington").SelectMany(c => c.Orders).Skip(2);

            //foreach (var order in res24)
            //{
            //    Console.WriteLine($"OrderID: {order.OrderID}, OrderDate: {order.OrderDate}, Total: {order.Total}");
            //}

            #endregion

            #region 3

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var res25 = numbers.TakeWhile((n, index) => n >= index);

            //foreach (var item in res25)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 4

            var res26 = numbers.SkipWhile(n => n % 3 != 0);

            //foreach( var item in res26)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 5

            var res27 = numbers.Select((num,index) => new {num , index}).SkipWhile(n => n.num >= n.index).Select(n => n.num);

            //foreach (var item in res27)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region LINQ - Quantifiers

            #region 1

            var res28 = strings.Any(s => s.Contains("ei"));

            //Console.WriteLine(res28); 

            #endregion

            #region 2

            var res29 = ProductList.GroupBy(p => p.Category).Where(g => g.Any(p =>p.UnitsInStock==0)).Select(g => new
            {
                Category = g.Key,
                Products = g.ToList()
            });

            //foreach (var item in res29)
            //{
            //    Console.WriteLine("Category: " + item.Category);
            //    foreach (var product in item.Products)
            //    {
            //        Console.WriteLine("   " + product.ProductName + " - Stock: " + product.UnitsInStock);
            //    }
            //}

            #endregion

            #region 3

            var res30 = ProductList.GroupBy(p => p.Category).Where(g => g.All(p => p.UnitsInStock > 0)).Select(g => new
            {
                Category = g.Key,
                Products = g.ToList()
            });

            //foreach (var item in res30)
            //{
            //    Console.WriteLine("Category: " + item.Category);
            //    foreach (var product in item.Products)
            //    {
            //        Console.WriteLine("   " + product.ProductName + " - Stock: " + product.UnitsInStock);
            //    }
            //}

            #endregion

            #endregion

            #region LINQ – Grouping Operators

            #region 1

            List<int> nums = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            var res31 = nums.GroupBy(n => n % 5).Select(g => new
            {
                Remainder = g.Key,
                Numbers = g.ToList()
            });

            //foreach (var item in res31)
            //{
            //    Console.WriteLine($"Numbers with a remainder of {item.Remainder} when divided by 5:");
            //    foreach (var n in item.Numbers)
            //    {
            //        Console.WriteLine(n);
            //    }
            //}

            #endregion

            #region 2

            var res32 = strings.GroupBy(s => s[0]).OrderBy(g => g.Key);

            //foreach (var group in res32)
            //{
            //    Console.WriteLine($"Words that start with the letter '{group.Key}':");
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine(word);
            //    }
            //}

            #endregion

            #region 3

            String[] str = { "from", "salt", "earn", " last", "near", "form" };

            var res33 = str.GroupBy(word => String.Concat(word.OrderBy(c => c)),        
                        (key, words) => new { Key = key, Words = words.ToList() }
                         );

            //foreach (var group in res33)
            //{
            //    Console.WriteLine($"Group {group.Key}:");
            //    foreach (var word in group.Words)
            //    {
            //        Console.WriteLine(word);
            //    }
            //}

            #endregion

            #endregion
        }
    }
}
