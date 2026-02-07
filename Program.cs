using System;
using System.Diagnostics.CodeAnalysis;

namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            int totalGrades = 4;
            double sum = 0.0;
            double average;
            double roundedAverage;

            Console.WriteLine("Enter 4 grades separated by new lines:");

            for (int i = 0; i < totalGrades; i++)
            {
                double grade = Convert.ToDouble(Console.ReadLine());
                sum += grade;
            }
            average = sum / totalGrades;
            roundedAverage = Math.Round(average);

            Console.WriteLine($"The average grade is: {average} and round off to {roundedAverage}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(); 
        }
    }
}