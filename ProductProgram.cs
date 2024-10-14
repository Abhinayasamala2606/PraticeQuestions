//using System.Security.Cryptography;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
namespace ConsoleApp3
{
    public class Product
    {
        public decimal CalculateTotalPrice(decimal price, int quantity)
        {
            decimal TotalPrice = price * quantity;
            return TotalPrice;
        }
        public decimal CalculateTotalPrice(decimal price, int quantity, int discountPercentage)
        {
            decimal TotalPriceWithDiscount = (price * quantity) - (price * quantity * discountPercentage / 100);
            return TotalPriceWithDiscount;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Price Without Discount");
            Console.WriteLine("2. Price With Discount");
            Console.WriteLine("Enter the choice");
            int n=int.Parse(Console.ReadLine());
            Product product = new Product();
            if (n == 1)
            {
                Console.WriteLine("Enter the price");
                decimal price = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter the quantity");
                int quantity = int.Parse(Console.ReadLine());
                product.CalculateTotalPrice(price, quantity);
                Console.WriteLine("Total price without discount "+product.CalculateTotalPrice(price, quantity));
            }
            else if(n == 2)
            {
                Console.WriteLine("Enter the price");
                decimal price = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter the quantity");
                int quantity = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the discount percentage");
                int discount = int.Parse(Console.ReadLine());
                Console.WriteLine("Total price with discount  "+product.CalculateTotalPrice(price, quantity, discount));
            }
           

        }
    }

}

