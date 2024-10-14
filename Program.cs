namespace PraticeQuestions
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer value");
            int a=int.Parse(Console.ReadLine());    
            Console.WriteLine("Enter a float value");
            float f=float.Parse(Console.ReadLine());
            Console.WriteLine("Enter a double value");
            double d=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a long value");
            long l=long.Parse(Console.ReadLine());
            Console.WriteLine("Enter a string");
            string s=Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("int: " + a);
            Console.WriteLine("float: " + f);
            Console.WriteLine("double: " + d);
            Console.WriteLine("long: " + l);
            Console.WriteLine("string: " + s);

        }
    }
}
