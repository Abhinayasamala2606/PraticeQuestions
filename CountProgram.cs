//using System.Security.Cryptography;
using System.Data.Common;
using System.Diagnostics.Tracing;
using System.Text;

namespace ConsoleApp30
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string S = Console.ReadLine();
            string[] words = S.Split(' ');
            int count = 1;
            string currentWord = words[0].Trim().ToUpper();

            for (int i = 1; i < words.Length; i++)
            {
                string word = words[i].Trim().ToUpper();

                if (currentWord == word)
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{currentWord}:{count}");
                    currentWord = word;
                    count = 1;

                }

            }
            Console.WriteLine($"{currentWord}:{count}");

        }
    }

}



