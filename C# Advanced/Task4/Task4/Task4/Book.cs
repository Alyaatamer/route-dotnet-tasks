using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string isbn, string title, string[] author, DateTime publicationDate, decimal price)
        {
            ISBN = isbn;
            Title = title;
            Authors = author;
            PublicationDate = publicationDate;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Title} by {string.Join(", ", Authors)} (ISBN: {ISBN}) - {PublicationDate.ToShortDateString()} - ${Price:F2}";
        }
    }
}
