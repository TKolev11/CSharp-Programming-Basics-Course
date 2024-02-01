namespace _07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nGroups = int.Parse(Console.ReadLine());
            int nPeopleInGroup = 0;
            double totalPeople = 0;
            double musala = 0;
            double montblanc = 0;
            double kilimanjaro = 0;
            double k2 = 0;
            double everest = 0;
            for (int i = 0; i < nGroups; i++)
            {
                nPeopleInGroup = int.Parse(Console.ReadLine());
                if (nPeopleInGroup <= 5)
                {
                    musala += nPeopleInGroup;
                }
                else if (nPeopleInGroup >= 6 && nPeopleInGroup <= 12)
                {
                    montblanc += nPeopleInGroup;
                }
                else if (nPeopleInGroup >= 13 && nPeopleInGroup <= 25)
                {
                    kilimanjaro += nPeopleInGroup;
                }
                else if (nPeopleInGroup >= 26 && nPeopleInGroup <= 40)
                {
                    k2 += nPeopleInGroup;
                }
                else if (nPeopleInGroup >= 41)
                {
                    everest += nPeopleInGroup;
                }
                totalPeople += nPeopleInGroup;
            }                  
            musala = (musala / totalPeople) * 100;
            montblanc = (montblanc / totalPeople) * 100;
            kilimanjaro = (kilimanjaro / totalPeople) * 100;
            k2 = (k2 / totalPeople) * 100;
            everest = (everest / totalPeople) * 100;
            Console.WriteLine($"{musala:F2}%");
            Console.WriteLine($"{montblanc:F2}%");
            Console.WriteLine($"{kilimanjaro:F2}%");
            Console.WriteLine($"{k2:F2}%");
            Console.WriteLine($"{everest:F2}%");
       
        }
    }
}
