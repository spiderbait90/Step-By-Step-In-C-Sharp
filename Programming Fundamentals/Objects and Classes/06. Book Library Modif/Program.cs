using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime Date { get; set; }
        public long ISBN { get; set; }
        public decimal Price { get; set; }

    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var library = new Library();
            library.Books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                Book book = new Book();
                {
                    book.Title = input[0];
                    book.Author = input[1];
                    book.Publisher = input[2];
                    book.Date = DateTime.ParseExact
                        (input[3], @"dd.MM.yyyy", CultureInfo.InvariantCulture);
                    book.ISBN = long.Parse(input[4]);
                    book.Price = decimal.Parse(input[5]);
                }
                library.Books.Add(book);
            }
            var date = DateTime.ParseExact
                        (Console.ReadLine(), @"dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var item in library.Books
                .Where(x=>x.Date>date)
                .OrderBy(x=>x.Date)
                .ThenBy(x=>x.Title))
            {
                Console.WriteLine($"{item.Title} ->" +
                    $" {item.Date.ToString(@"dd.MM.yyyy")}");
            }
        }
    }
}
