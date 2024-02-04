namespace _08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournamentsCount = int.Parse(Console.ReadLine());
            int initialPoints = int.Parse(Console.ReadLine());
            int wPoints = 0;
            int fPoints = 0;
            int sfPoints = 0;

            int totalPoints = initialPoints;
            int winsCount = 0;

            for (int i = 0; i < tournamentsCount; i++)
            {
                string result = Console.ReadLine();

                switch (result)
                {
                    case "W":
                        totalPoints += 2000;
                        wPoints += 2000;
                        winsCount++;
                        break;
                    case "F":
                        totalPoints += 1200;
                        fPoints += 1200;
                        break;
                    case "SF":                     
                        totalPoints += 720;
                        sfPoints += 720;
                        break;
                }
            }

            double averagePoints = Math.Floor(((double)sfPoints + (double)wPoints + (double)fPoints) / tournamentsCount);
            double winPercentage = (double)winsCount / tournamentsCount * 100;

            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{winPercentage:F2}%");
        }
   
    }
}
