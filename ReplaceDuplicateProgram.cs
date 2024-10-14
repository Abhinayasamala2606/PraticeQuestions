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
        public void ReplaceDuplicateWithSpecialChar(ref char[] chars, char specialChar)
        {
            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (chars[i] == chars[j])
                    {
                        chars[i] = specialChar;
                        break;
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Enter the array size");
            int size = int.Parse(Console.ReadLine());
            char[] chars = new char[size];
            Console.WriteLine("Enter the characters");
            for (int i = 0; i < size; i++)
            {
                chars[i] = Console.ReadKey().KeyChar;
                Console.WriteLine(); 
            }

            Console.WriteLine("Enter the special character");
            char specialChar = Console.ReadKey().KeyChar;

            
            program.ReplaceDuplicateWithSpecialChar(ref chars, specialChar);

           
            Console.WriteLine("Resulting characters:");
            foreach (char c in chars)
            {
                Console.WriteLine(c);
            }

           
            Console.WriteLine("string: Hello");
        }
    }

}




