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
                public int[] FindStudentsRank(int[,] stdMarks)
                {
                    int numStudents = stdMarks.GetLength(0);
                    int[] totalMarks = new int[numStudents];
                    int[] ranks = new int[numStudents];

                   
                    for (int i = 0; i < numStudents; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            totalMarks[i] += stdMarks[i, j];
                        }
                    }

                    
                    for (int i = 0; i < numStudents; i++)
                    {
                        int rank = 1; 
                        for (int j = 0; j < numStudents; j++)
                        {
                            if (totalMarks[j] > totalMarks[i])
                            {
                                rank++;
                            }
                        }
                        ranks[i] = rank;
                    }

                    return ranks;
                }

                public static void Main()
                {
                    Program program = new Program();

                    Console.WriteLine("Enter the number of students");
                    int numberOfStudents = int.Parse(Console.ReadLine());

                   
                    int[,] studentMarks = new int[numberOfStudents, 5];

                    
                    for (int i = 0; i < numberOfStudents; i++)
                    {
                        Console.WriteLine($"Enter marks for Student{i+1} ");
                        for (int j = 0; j < 5; j++)
                        {
                            studentMarks[i, j] = int.Parse(Console.ReadLine());
                        }
                    }

                    
                    int[] ranks = program.FindStudentsRank(studentMarks);

                  
                    for (int i = 0; i < numberOfStudents; i++)
                    {
                        Console.WriteLine($"Rank of student {i + 1} is {ranks[i]}");
                    }
                }
            

    }
  
}




