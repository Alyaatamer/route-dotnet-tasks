using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class BookFunctions
    {
        public static string GetTitle(Book book)
        {
            return book.Title;
        }
        public static string GetAuthors(Book book)
        {
            return string.Join(", ", book.Authors);
        }
        public static string GetPrice(Book book)
        {
            return book.Price.ToString("C2");
        }
    }
}
