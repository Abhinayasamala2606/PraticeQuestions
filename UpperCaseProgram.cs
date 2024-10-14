namespace ConsoleApp30
{
    public class UpperCaseProgram
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word");
            string s=Console.ReadLine();

           
          foreach(char i in s)
          {
                bool upper = true;
                char res;
                if (upper)
                {
                    res = char.ToUpper(i);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(char.ToLower(i));
                }
            }
            
        }
    }
}
