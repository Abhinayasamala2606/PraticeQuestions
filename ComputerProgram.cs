//using System.Security.Cryptography;
using System.Data.Common;
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
namespace ConsoleApp3
{
    public class Computer
    {
        public string Processor { get; set; }
        public int RamSize { get; set; }
        public int HardDiskSize { get; set; }
        public int GraphicCard { get; set; }
    }

    public class Desktop : Computer
    {
        public int MonitorSize { get; set; }
        public int PowerSupplyVolt { get; set; }

        public double DesktopPriceCalculation()
        {
            double processorCost = Processor switch
            {
                "i3" => 1500,
                "i5" => 3000,
                "i7" => 4500,
                _ => 0
            };

            const double ramPrice = 200;
            const double hardDiskPrice = 1500;
            const double graphicCardPrice = 2500;
            const double powerSupplyPrice = 20;
            const double monitorPrice = 250;

            return processorCost +
                   (RamSize * ramPrice) +
                   (HardDiskSize * hardDiskPrice) +
                   (GraphicCard * graphicCardPrice) +
                   (MonitorSize * monitorPrice) +
                   (PowerSupplyVolt * powerSupplyPrice);
        }
    }

    public class Laptop : Computer
    {
        public int DisplaySize { get; set; }
        public int BatteryVolt { get; set; }

        public double LaptopPriceCalculation()
        {
            double processorCost = Processor switch
            {
                "i3" => 2500,
                "i5" => 5000,
                "i7" => 6500,
                _ => 0
            };

            const double ramPrice = 200;
            const double hardDiskPrice = 1500;
            const double graphicCardPrice = 2500;
            const double batteryPrice = 20;
            const double displayPrice = 250;

            return processorCost +
                   (RamSize * ramPrice) +
                   (HardDiskSize * hardDiskPrice) +
                   (GraphicCard * graphicCardPrice) +
                   (DisplaySize * displayPrice) +
                   (BatteryVolt * batteryPrice);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Desktop");
            Console.WriteLine("2. Laptop");
            Console.Write("Choose the option: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Desktop desktop = new Desktop();

                Console.Write("Enter the processor: ");
                desktop.Processor = Console.ReadLine();
                Console.Write("Enter the RAM size: ");
                desktop.RamSize = int.Parse(Console.ReadLine());
                Console.Write("Enter the hard disk size: ");
                desktop.HardDiskSize = int.Parse(Console.ReadLine());
                Console.Write("Enter the graphic card size: ");
                desktop.GraphicCard = int.Parse(Console.ReadLine());
                Console.Write("Enter the monitor size: ");
                desktop.MonitorSize = int.Parse(Console.ReadLine());
                Console.Write("Enter the power supply volt: ");
                desktop.PowerSupplyVolt = int.Parse(Console.ReadLine());
                 
                double price = desktop.DesktopPriceCalculation();
                Console.WriteLine($"Desktop price is {price}");
            }
            else if (choice == 2)
            {
                Laptop laptop = new Laptop();

                Console.Write("Enter the processor: ");
                laptop.Processor = Console.ReadLine();
                Console.Write("Enter the RAM size: ");
                laptop.RamSize = int.Parse(Console.ReadLine());
                Console.Write("Enter the hard disk size: ");
                laptop.HardDiskSize = int.Parse(Console.ReadLine());
                Console.Write("Enter the graphic card size: ");
                laptop.GraphicCard = int.Parse(Console.ReadLine());
                Console.Write("Enter the display size: ");
                laptop.DisplaySize = int.Parse(Console.ReadLine());
                Console.Write("Enter the battery volt: ");
                laptop.BatteryVolt = int.Parse(Console.ReadLine());

                double price = laptop.LaptopPriceCalculation();
                Console.WriteLine($"Laptop price is {price}");
            }
            else
            {
                Console.WriteLine("Invalid option selected.");
            }
        }
    }

}

