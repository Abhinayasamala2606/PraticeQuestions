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
        public string UpdatePrice(string[] details, int id, double amount)
        {


            for (int i = 0; i < details.Length; i++)
            {
                string[] product = details[i].Split(':');
                if (int.Parse(product[0]) == id)
                {
                    product[2] = amount.ToString();
                    //details[i] = string.Join(":", product);
                    Console.WriteLine($"{product[1]} {product[2]}");
                }
            }
            return "Not found";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of products");
            int n=int.Parse(Console.ReadLine());
            string[] details = new string[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write("Enter the product details : ");
                details[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter the product id");
            int Id=int.Parse(Console.ReadLine());   
            Console.WriteLine("Enter the amount to update");
            double amount=double.Parse(Console.ReadLine());
            Program program = new Program();
            program.UpdatePrice(details,Id,amount);
        }
    }

}




