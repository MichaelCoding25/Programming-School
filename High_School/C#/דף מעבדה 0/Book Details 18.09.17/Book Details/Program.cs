using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Details
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName, authorName;
            float price;
            int pageNum;

            Console.WriteLine("What is the book's name?");
            bookName = Console.ReadLine();
            Console.WriteLine("What is the author's name?");
            authorName = Console.ReadLine();
            Console.WriteLine("Please state the price of the book (in dollars):");
            price = float.Parse(Console.ReadLine());
            Console.WriteLine("Please state the number of pages this book has:");
            pageNum = int.Parse(Console.ReadLine());
            Console.WriteLine("The book " + bookName + " by " + authorName + " costs " + price + " dollars, and it has " + pageNum + " pages.");
            Console.ReadLine();
        }
    }
}
