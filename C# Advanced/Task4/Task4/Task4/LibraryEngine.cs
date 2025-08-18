using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public delegate string BookDelegate(Book b);
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> blist, BookDelegate fPtr)
        {
            foreach (Book B in blist)
            {
                Console.WriteLine(fPtr(B));
            }
        }
        public static void ProcessBooksFunc(List<Book> blist, Func<Book,string> fPtr)
        {
            foreach (Book B in blist)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
}
