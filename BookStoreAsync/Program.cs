using Core.Models;
namespace BookStoreAsync
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            BookStore bookStore = new BookStore();
            bool exit = false;

            while (!exit)
            {                
                Console.WriteLine("\nKitab magazasi");
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Butun Kitablari gor");
                Console.WriteLine("2. Kitab axtar");
                Console.WriteLine("3. Kitab al");
                Console.WriteLine("4. Cixis");
                Console.Write("Secim edin : ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        await bookStore.DisplayBooksAsync();
                        break;
                    case "2":
                        await bookStore.SearchBookAsync();
                        break;
                    case "3":
                        await bookStore.PurchaseBookAsync();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Secim yanlisdir! Yeniden daxil edin...");
                        break;
                }
            }
        }
    }
}
