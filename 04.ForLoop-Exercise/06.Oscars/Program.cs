namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int numOfJudges = int.Parse(Console.ReadLine());
        
            double currentPoints = academyPoints;
          

            for (int i = 0; i < numOfJudges; i++)
            {                
                string judgeName = Console.ReadLine();  
                double judgePoints = double.Parse(Console.ReadLine());                
                currentPoints = currentPoints + ((judgeName.Length * judgePoints) / 2);
                judgePoints = 0;           
               if (currentPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {currentPoints:F1}!");
                    return;
                }
            }         
            if (currentPoints < 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - currentPoints:F1} more!");
            }
        }
    }
}
