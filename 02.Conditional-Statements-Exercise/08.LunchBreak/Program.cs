namespace _08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameForSerial = Console.ReadLine();
            int episodeDuration = int.Parse(Console.ReadLine());
            int restDuration = int.Parse(Console.ReadLine());

            double timeForLunch = (double)restDuration / 8;
            double timeForRest = (double)restDuration / 4;
            double timeLeft = restDuration - timeForLunch - timeForRest;
            if (timeLeft >= episodeDuration)
            {
                Console.WriteLine($"You have enough time to watch {nameForSerial} and left with {(int)Math.Ceiling(timeLeft - episodeDuration)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {nameForSerial}, you need {(int)Math.Ceiling(episodeDuration - timeLeft)} more minutes.");
            }
        }
    }
}
