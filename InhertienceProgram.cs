//using System.Security.Cryptography;
using System.Data.Common;
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
namespace ConsoleApp31
{
    public class Owner
    {
        protected string ownerName;
    }

    public class Car : Owner
    {
        internal double price;
        private string bodyStyle;

        public string BodyStyle
        {
            get { return bodyStyle; }
            set { bodyStyle = value; }
        }

        public bool ValidateBodyStyle(string bodyStyle)
        {
            return bodyStyle == "SUV" || bodyStyle == "Sedan";
        }

        public double CalculatePrice()
        {
            if (bodyStyle == "SUV")
            {
                return price - (price * 0.10);
            }
            else if (bodyStyle == "Sedan")
            {
                return price - (price * 0.25);
            }
            return 0;
        }

        public void SetOwnerName(string name)
        {
            ownerName = name;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        { 
            Car car = new Car();
            Console.WriteLine("Enter the owner name:");
            string ownerName = Console.ReadLine();
            car.SetOwnerName(ownerName);

            Console.WriteLine("Enter the car body style:");
            string bodyStyle = Console.ReadLine();
            car.BodyStyle = bodyStyle;

            Console.WriteLine("Enter the price:");
            car.price = double.Parse(Console.ReadLine());

            if (!car.ValidateBodyStyle(car.BodyStyle))
            {
                Console.WriteLine("Invalid Car Type");
            }
            else
            {
                double finalPrice = car.CalculatePrice();
                Console.WriteLine($"The owner sells the {car.BodyStyle} type car for ${finalPrice}");
            }
        }
    }

}




