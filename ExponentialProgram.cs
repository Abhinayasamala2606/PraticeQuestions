//using System.Security.Cryptography;
using System.Data.Common;
using System.Text;

namespace ConsoleApp30
{
    public class Program
    {
        public StringBuilder FindExponential(int number)
        {
            StringBuilder sb = new StringBuilder("Exponential is ");
            
            Math.Exp(number).ToString("E");
            sb.Append(Math.Exp(number).ToString("E"));
            return sb;
        }
        public StringBuilder ReplaceWord(string sentence, string word1, string word2)
        {
           
            StringBuilder result=new StringBuilder(sentence.Replace(word1,word2));
            return result;

         
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("1.Find Exponential");
            Console.WriteLine("2.Replace Word");
            Console.WriteLine("Choose the option");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("Enter the number");
                int Num = int.Parse(Console.ReadLine());
                StringBuilder res = program.FindExponential(Num);
                Console.WriteLine(res);
            }
            else if(n == 2)
            {
                Console.WriteLine("Enter a sentence");
                string sentence = Console.ReadLine();
                Console.WriteLine("Enter the word you want to replace");
                string word1 = Console.ReadLine();
                Console.WriteLine("Enter the replaced word");
                string word2 = Console.ReadLine();
                StringBuilder res1 = program.ReplaceWord(sentence, word1, word2);
                Console.WriteLine(res1);

            }
            else
            {
                Console.WriteLine("Invalid output");
            }


           

        }
        
    }
}
