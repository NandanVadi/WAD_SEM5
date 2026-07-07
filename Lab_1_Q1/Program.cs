using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int marks;
            double percentage;
            string grade;

            for (int i = 1; i <= 5; i++)
            {
                while (true)
                {
                    Console.Write("Enter marks for Subject " + i + ": ");
                    if (int.TryParse(Console.ReadLine(), out marks) && marks >= 0 && marks <= 100)
                    {
                        total += marks;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Enter marks between 0 and 100.");
                    }
                }
            }

            percentage = total / 5.0;

            if (percentage >= 90)
                grade = "A+";
            else if (percentage >= 80)
                grade = "A";
            else if (percentage >= 70)
                grade = "B";
            else if (percentage >= 60)
                grade = "C";
            else if (percentage >= 50)
                grade = "D";
            else
                grade = "F";

            Console.WriteLine();
            Console.WriteLine("Total Marks: " + total);
            Console.WriteLine("Percentage: " + percentage.ToString("F2") + "%");
            Console.WriteLine("Grade: " + grade);
        }
    }
}