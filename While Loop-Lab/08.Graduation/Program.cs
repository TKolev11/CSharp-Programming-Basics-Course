using System.Net.Http.Headers;

namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string studentName = Console.ReadLine();

            double totalGrade = 0;
            int gradeCount = 0;
            int currentGrade = 0;

            while (currentGrade < 12)
            {
                currentGrade++;               
                double gradeInput;

                if (double.TryParse(Console.ReadLine(), out gradeInput))
                {
                    if (gradeInput >= 4.00)
                    {
                        totalGrade += gradeInput;
                        gradeCount++;
                    }
                    else
                    {
                        Console.WriteLine($"{studentName} has been excluded at {currentGrade} grade");
                        return;
                    }
                }
               
            }

            double averageGrade = totalGrade / gradeCount;
            Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:F2}");
        }
    }
}
