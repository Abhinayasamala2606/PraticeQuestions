//using System.Security.Cryptography;
using System.Data.Common;
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp30
{
    public class Program
    {
        public object CalculateDiscountedPrice(object totalCost)
        {
            double cost = (double)totalCost;
            double discount = 0;

            
            if (cost >= 100 && cost <= 500)
            {
                discount = 0.05 * cost; 
            }
            else if (cost > 500 && cost <= 1000)
            {
                discount = 0.15 * cost; 
            }
            else if (cost > 1000)
            {
                discount = 0.30 * cost; 
            }
            double discountedPrice = cost - discount;

            return (object)discountedPrice;
        }

        public static void Main()
        {
            Program program = new Program();

            Console.WriteLine("Enter the total cost");
            double totalCost = double.Parse(Console.ReadLine());
            object boxedCost = (object)totalCost;
            object discountedPrice = program.CalculateDiscountedPrice(boxedCost);
            Console.WriteLine($"Price after discount is {discountedPrice}");
        }
    }



}




