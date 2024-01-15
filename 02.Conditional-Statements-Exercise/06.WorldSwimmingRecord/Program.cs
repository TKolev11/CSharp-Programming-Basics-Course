namespace _06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double timePerMeterSeconds = double.Parse(Console.ReadLine());

            double playerTime = distanceMeters * timePerMeterSeconds;
            double resistanceDelay = Math.Floor(distanceMeters / 15) * 12.5;        
            double totalTime = playerTime + resistanceDelay;
            
            if (recordInSeconds > totalTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - recordInSeconds:F2} seconds slower.");
            }
        }
    }
}
