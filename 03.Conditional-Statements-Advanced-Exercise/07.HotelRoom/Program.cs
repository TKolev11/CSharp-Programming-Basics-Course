namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartmentPrice = 0;
 

            switch (month)
            {
                case "May":
                case "October":
                    {
                        studioPrice = 50;
                        apartmentPrice = 65;
                        if (nights > 7  && nights <= 14)
                        {
                             studioPrice -= 2.50;
                        }
                        else if (nights > 14)                      
                        {
                            studioPrice -= 15;
                            apartmentPrice -= 6.50;

                            
                        }
                        Console.WriteLine($"Apartment: {apartmentPrice * nights:F2} lv.");
                        Console.WriteLine($"Studio: {studioPrice * nights:F2} lv.");
                        break;
                    }
                case "June":
                case "September":
                    {
                        studioPrice = 75.20;
                        apartmentPrice = 68.70;
                        if (nights > 14)
                        {
                            studioPrice -= 15.04;
                            apartmentPrice -= 6.87;
                        }
                        Console.WriteLine($"Apartment: {apartmentPrice * nights:F2} lv.");
                        Console.WriteLine($"Studio: {studioPrice * nights:F2} lv.");
                        break;
                    }
                case "July":
                case "August":
                    {
                        studioPrice = 76;
                        apartmentPrice = 77;
                        if (nights > 14)
                        {
                            apartmentPrice -= 7.7;
                        }
                        Console.WriteLine($"Apartment: {apartmentPrice * nights:F2} lv.");
                        Console.WriteLine($"Studio: {studioPrice * nights:F2} lv.");
                        break;
                    }
            }
        }
    }
}
