namespace _03.Time_15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            if (hours < 23 && hours >= 0 && minutes < 59 && minutes >= 0 )
            {
                int newHours = ((hours * 60) + minutes + 15) / 60;
                int newMinutes = ((hours * 60) + minutes + 15) % 60;
                if(newMinutes < 10)
                {
                    Console.WriteLine($"{newHours}:0{newMinutes}");
                }
                else
                {
                    Console.WriteLine($"{newHours}:{newMinutes}");
                }
            }
            else
            {
                int newHours = ((hours * 60) + minutes + 15) / 60 % 24;
                int newMinutes = ((hours * 60) + minutes + 15) % 60;
             
                if (newMinutes < 10)
                {
                    Console.WriteLine($"{newHours}:0{newMinutes}");
                }
                else
                {
                    Console.WriteLine($"{newHours}:{newMinutes}");
                }
            }
        }
    }
}
