using System.Diagnostics.Metrics;

namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());                
            int solvedTasks = 0;
            int badGradesCounter = 0;
            double averageScore = 0;
            string lastTask = "";
            bool isFailed = true;
            while (badGradesCounter < badGrades)               
            {
                string problemName = Console.ReadLine();    
                if (problemName == "Enough")
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    badGradesCounter++;                    
                }
                averageScore += grade;
                lastTask = problemName;
                solvedTasks++;
            }
            averageScore /= solvedTasks;
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {badGradesCounter} poor grades.");
            } 
            else
            {                
                Console.WriteLine($"Average score: {averageScore:F2}");
                Console.WriteLine($"Number of problems: {solvedTasks}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
          
        }
    }
}
