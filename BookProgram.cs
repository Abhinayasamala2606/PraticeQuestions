//using System.Security.Cryptography;
using System.Data.Common;
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
namespace ConsoleApp3
{
    public class Book
    {
        private string title;
        private string author;
        private int numPages;
        private DateTime dueDate;
        private DateTime returnedDate;

        public Book()
        {
            title = "Unknown Title";
            author = "Unknown Author";
            numPages = 0;
            dueDate = DateTime.Now;
            returnedDate = DateTime.Now;
        }

        public Book(string title, string author, int numPages, DateTime dueDate, DateTime returnedDate)
        {
            this.title = title;
            this.author = author;
            this.numPages = numPages;
            this.dueDate = dueDate;
            this.returnedDate = returnedDate;
        }

        public double AveragePagesReadPerDay(int daysToRead)
        {
            return (double)numPages / daysToRead;
        }

        public double CalculateLateFee(double dailyLateFeeRate)
        {
            int daysLate = (returnedDate - dueDate).Days;
            if (daysLate > 0)
            {
                return daysLate * dailyLateFeeRate;
            }
            return 0; 
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the title:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter the author:");
            string author = Console.ReadLine();

            Console.WriteLine("Enter the number of pages:");
            int numPages = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the due date (MM/DD/YYYY):");
            DateTime dueDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the return date (MM/DD/YYYY):");
            DateTime returnedDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the days to read:");
            int daysToRead = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the daily late fee rate:");
            double dailyLateFeeRate = double.Parse(Console.ReadLine());

            Book book = new Book(title, author, numPages, dueDate, returnedDate);

            double averagePages = book.AveragePagesReadPerDay(daysToRead);
            double lateFee = book.CalculateLateFee(dailyLateFeeRate);

            Console.WriteLine($"Average Pages Read Per Day: {averagePages}");
            Console.WriteLine($"Late Fee: {lateFee}");
        }
    }

}




