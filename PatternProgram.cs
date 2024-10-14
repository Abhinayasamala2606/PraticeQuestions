namespace ConsoleApp31
{
    public class PatternProgram
    { 
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                int j = 1;
                do
                {
                    Console.Write(i);
                    Console.WriteLine(j);
                    j++;
                } while (j <= 2);
                //Console.WriteLine(j);
                //Console.WriteLine(i);

                i++;
            } while (i <=5);
                //Console.WriteLine(i);
            
            
        }
    }
}
