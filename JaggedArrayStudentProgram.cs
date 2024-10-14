//using System.Security.Cryptography;
using System.Data.Common;
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp30
{
    using System;

    public class Program
    {
        public string FindWhoGotMaximumPoints(int[][] points)
        {
            int maxPoints = 0;
            int studentIndex = -1;

           
            for (int i = 0; i < points.Length; i++)
            {
                int totalPoints = 0;
                for (int j = 0; j < points[i].Length; j++)
                {
                    totalPoints += points[i][j];
                }

              
                if (totalPoints > maxPoints)
                {
                    maxPoints = totalPoints;
                    studentIndex = i; 
                }
            }

           
            return $"Student {studentIndex + 1} got maximum points."; 
        }

        public static void Main()
        {
            Program program = new Program();

            Console.WriteLine("Enter the number of students");
            int numberOfStudents = int.Parse(Console.ReadLine());

           
            int[][] studentPoints = new int[numberOfStudents][];

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine($"Enter the number of competitions attended by student {i + 1}");
                int numCompetitions = int.Parse(Console.ReadLine());
                studentPoints[i] = new int[numCompetitions]; 

                Console.WriteLine($"Enter the student {i + 1} points");
                for (int j = 0; j < numCompetitions; j++)
                {
                    studentPoints[i][j] = int.Parse(Console.ReadLine());
                }
            }

           
            string result = program.FindWhoGotMaximumPoints(studentPoints);
            Console.WriteLine(result);
        }
    }


}




