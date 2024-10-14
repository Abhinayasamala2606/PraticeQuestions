//using System.Security.Cryptography;
using System.Data.Common;
using System.Text;

namespace ConsoleApp31
{
    public class Program
    {
        public  StringBuilder WordInserting(StringBuilder word1, char ch, string word2)
        {
            int index = word1.ToString().IndexOf(ch);
            if (index > -1)
            {
                word1.Remove(index, 1);
                word1.Insert(index, word2);
            }
            return word1;
        }

            static void Main(string[] args)
            {
                Console.WriteLine("Enter the word1");
                StringBuilder word1 = new StringBuilder(Console.ReadLine());
                
                Console.WriteLine("Search Character in word1");
                char ch = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter the word2");
                string word2 = Console.ReadLine();
                Program program = new Program();
                StringBuilder result = program.WordInserting(word1, ch, word2);
                Console.WriteLine("Result: " + result);

           
            
           
        }
        
    }
}
