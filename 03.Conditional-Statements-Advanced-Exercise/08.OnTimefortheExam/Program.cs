namespace _08.OnTimefortheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            int examTime = examHour * 60 + examMinute;
            int arrivalTime = arrivalHour * 60 + arrivalMinute;

            if (examTime < arrivalTime)
            {
                Console.WriteLine("Late");
            }
            else if (examTime - arrivalTime <= 30)
            {
                Console.WriteLine("On time");
            }
            else
            {
                Console.WriteLine("Early");
            }

            int difference = Math.Abs(examTime - arrivalTime);
            if (difference > 0 && difference < 60)
            {
                Console.WriteLine($"{difference} minutes {(arrivalTime > examTime ? "after" : "before")} the start");
            }
            else
            {
                int hours = difference / 60;
                int minutes = difference % 60;
                Console.WriteLine($"{hours}:{minutes:D2} hours {(arrivalTime > examTime ? "after" : "before")} the start");
            }
        }
    }
}
