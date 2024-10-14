//using System.Security.Cryptography;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
namespace ConsoleApp3
{
    public class Car
    {
        public String Make { get; set; }
        public String Model { get; set; }
        public int Year { get; set; }
        public virtual double CalculateCost(double basePrice, int currentYear)
        {
            return basePrice;
        }
    }
    public class SportsCar : Car
    {
        public override double CalculateCost(double basePrice, int currentYear)
        { 
            double FixedTaxRate = 0.1;
            double Age = currentYear - Year;
            double TotalTax = basePrice* FixedTaxRate* Age;
            double TotalCost = basePrice + TotalTax;
            return TotalCost;
        }
    }
    public class SUV : Car
    {
        public override double CalculateCost(double basePrice, int currentYear)
        {
            double FixedTaxRate = 0.05;
            double Age = currentYear - Year;
            double TotalTax = basePrice * FixedTaxRate * Age;
            double TotalCost = basePrice + TotalTax;
            return TotalCost;
        }
    }
    public class Program 
    { 
        public static void Main(string[] args)
        {
            Console.WriteLine("1.Sports car");
            Console.WriteLine("2.SUV car");
            Console.WriteLine("3.None of the above");
            Console.WriteLine("Choose the Option");
            int n=int.Parse(Console.ReadLine());
            Car car = new Car();
            if (n == 1)
            {
                Console.WriteLine("Enter the make");
                string make=Console.ReadLine();
                Console.WriteLine("Enter the model");
                String model=Console.ReadLine();
                Console.WriteLine("Enter the year the car was made");
                int Year=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the basic price");
                double baseprice=double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the current year");
                int currentyear=int.Parse(Console.ReadLine());
                SportsCar sportsCar = new SportsCar();
                sportsCar.CalculateCost(baseprice, currentyear);
                Console.WriteLine("Sports car cost is  " + sportsCar.CalculateCost(baseprice, currentyear));
            }
            else if(n == 2)
            {
                Console.WriteLine("Enter the make");
                string make = Console.ReadLine();
                Console.WriteLine("Enter the model");
                String model = Console.ReadLine();
                Console.WriteLine("Enter the year the car was made");
                int Year = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the basic price");
                double baseprice = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the current year");
                int currentyear = int.Parse(Console.ReadLine());
                SUV s=new SUV();
                s.CalculateCost(baseprice, currentyear);
                Console.WriteLine("SUV car cost is  " + s.CalculateCost(baseprice, currentyear));

            }
            else if(n == 3)
            {
                Console.WriteLine("Enter the make");
                string make = Console.ReadLine();
                Console.WriteLine("Enter the model");
                String model = Console.ReadLine();
                Console.WriteLine("Enter the year the car was made");
                int Year = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the basic price");
                double baseprice = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the current year");
                int currentyear = int.Parse(Console.ReadLine());
                car.CalculateCost(baseprice, currentyear);
                Console.WriteLine("Car cost is  " + car.CalculateCost(baseprice, currentyear));
            }


        }
    }

}

