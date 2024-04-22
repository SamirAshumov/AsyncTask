using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class BookStore
    {
        private List<Book> books = new List<Book>()
        {
            new Book { Title = "Kitab 1", Author = "Author 1", Price = 18.75 },
            new Book { Title = "Kitab 2", Author = "Author 2", Price = 22.50 },
            new Book { Title = "Kitab 3", Author = "Author 3", Price = 12 },
            new Book { Title = "Kitab 4", Author = "Author 4", Price = 18 },
            new Book { Title = "Kitab 5", Author = "Author 5", Price = 15 },
            new Book { Title = "Kitab 6", Author = "Author 6", Price = 19.40 }
        };

        public async Task DisplayBooksAsync()
        {
            Console.WriteLine("\nMovcud kitablarin siyahisi:");
            foreach (var book in books)
            {
                await Task.Delay(500); 
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Price: {book.Price} azn");
            }
        }

        public async Task SearchBookAsync()
        {
            Console.Write("\nKitabin Title-ni daxil edin: ");
            string title = Console.ReadLine();

            var book = books.Find(b => b.Title.ToLower() == title.ToLower());
            if (book != null)
            {
                await Task.Delay(500);
                Console.WriteLine($"\nKitab tapildi - Title: {book.Title}, Author: {book.Author}, Price: {book.Price} azn");
            }
            else
            {
                await Task.Delay(300);
                Console.WriteLine("\nKitab tapilmadi!");
            }
        }

        public async Task PurchaseBookAsync()
        {
            Console.Write("\nAlmaq istediyiniz kitabin title-ni daxil edin: ");
            string title = Console.ReadLine();

            var book = books.Find(b => b.Title.ToLower() == title.ToLower());
            if (book != null)
            {
                await Task.Delay(500);
                Console.WriteLine($"\nKitabi aldiniz - Title: {book.Title}, Author: {book.Author}, Price: {book.Price} azn");
            }
            else
            {
                await Task.Delay(300); 
                Console.WriteLine("\nKitab tapilmadi!");
            }
        }

    }
}
