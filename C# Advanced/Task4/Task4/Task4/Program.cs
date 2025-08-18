namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01


            List<Book> books = new List<Book>
            {
                new Book("1","oop", new string[] { "Author1", "Author2" }, new DateTime(2020, 1, 1), 29.99m),
                new Book("2","c#", new string[] { "Author1", "Author2" }, new DateTime(2020, 1, 1), 29.99m),
                new Book("3","sql server", new string[] { "Author1", "Author2" }, new DateTime(2020, 1, 1), 29.99m),
            };

            // Using user-defined delegate
            BookDelegate del = new BookDelegate(BookFunctions.GetTitle);
            LibraryEngine.ProcessBooks(books, del);

            // Using Func delegate
            Func<Book, string> func = BookFunctions.GetAuthors;
            LibraryEngine.ProcessBooksFunc(books, func);

            // using Anonymous Method
            LibraryEngine.ProcessBooks(books, delegate (Book b)
            {
                return $"{b.Title} - {b.Price:C2}";
            });

            // using Lambda Expression
            LibraryEngine.ProcessBooks(books, b => b.PublicationDate.ToShortDateString());

            // List methods
            Listmethods<int> numbers = new Listmethods<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);

            Console.WriteLine(numbers.Exists(x => x > 0));
            Console.WriteLine(numbers.Find(x => x > 0));

            Console.WriteLine("MyList FindAll even numbers:");
            var evens = numbers.FindAll(x => x % 2 == 0);
            evens.ForEach(x => Console.WriteLine(x));

            Console.WriteLine(numbers.FindIndex(x => x == 2));
            Console.WriteLine(numbers.FindLast(x => x > 1));
            Console.WriteLine(numbers.FindLastIndex(x => x < 2));

            Console.WriteLine("MyList ForEach print:");
            numbers.ForEach(x => Console.WriteLine(x));

            Console.WriteLine(numbers.TrueForAll(x => x < 1));

            #endregion
        }
    }
}
