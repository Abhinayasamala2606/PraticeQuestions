//using System.Security.Cryptography;
using System.Data.Common;
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
namespace ConsoleApp30
{ 
    public class Candy
    {
        public string Flavour { get; set; }
        public int Quantity { get; set; }
        public int PricePerPiece { get; set; }
        public double TotalPrice { get; set; }
        public double DiscountPrice { get; set; }

        public bool ValidateCandyFlavour()
        {
            return Flavour == "Strawberry" || Flavour == "Lemon" || Flavour == "Mint";
        }
    }

    public class Program
    {
        public Candy CalculateDiscountedPrice(Candy candy)
        {
            candy.TotalPrice = candy.Quantity * candy.PricePerPiece;
            double discountPercentage = 0;

            switch (candy.Flavour)
            {
                case "Strawberry":
                    discountPercentage = 15;
                    break;
                case "Lemon":
                    discountPercentage = 10;
                    break;
                case "Mint":
                    discountPercentage = 5;
                    break;
            }

            candy.DiscountPrice = candy.TotalPrice - (candy.TotalPrice * discountPercentage / 100);
            return candy;
        }

        public static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("Enter the flavour");
            string flavour = Console.ReadLine();

            Console.WriteLine("Enter the quantity");
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the price per piece");
            int pricePerPiece = int.Parse(Console.ReadLine());

            Candy candy = new Candy
            {
                Flavour = flavour,
                Quantity = quantity,
                PricePerPiece = pricePerPiece
            };
            if (candy.ValidateCandyFlavour())
            {
                candy = program.CalculateDiscountedPrice(candy);

                Console.WriteLine($"Flavour : {candy.Flavour}");
                Console.WriteLine($"Quantity : {candy.Quantity}");
                Console.WriteLine($"Price Per Piece : {candy.PricePerPiece}");
                Console.WriteLine($"Total Price : {candy.TotalPrice}");
                Console.WriteLine($"Discount Price : {candy.DiscountPrice}");
            }
            else
            {
                Console.WriteLine("Invalid flavour");
            }
        }
    }


}




