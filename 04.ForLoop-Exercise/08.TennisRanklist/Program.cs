namespace _08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nTournaments = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            string milestoneReached = "";
            int currentPoints = startPoints;
            int wPoints = 0;
            int fPoints = 0;
            int sfPoints = 0;
            double tournamentsWon = 0;


            for (int i = 0; i < nTournaments; i++)
            {
                milestoneReached = Console.ReadLine();
                if (milestoneReached == "W")
                {
                    currentPoints += 2000;             
                    wPoints += 2000;
                    tournamentsWon++;
                }
                else if (milestoneReached == "F")
                {
                    currentPoints += 1200;                   
                    fPoints += 1200;     
                }
                else if (milestoneReached == "SF")
                {
                    currentPoints += 720;
                    sfPoints += 720;              
                }
            }         
            int avgWonTournaments = (wPoints + fPoints + sfPoints) / nTournaments;           
            double percentageWonTournaments = (tournamentsWon / nTournaments) * 100;
            Console.WriteLine($"Final points: {currentPoints}");
            Console.WriteLine($"Average points: {avgWonTournaments}");
            Console.WriteLine();
            Console.WriteLine($"{percentageWonTournaments:F2}%");
        }
    }
}
