namespace _05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOpenTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            

            for (int i = 0; i < numOpenTabs; i++)
            {
                string tabOpened = Console.ReadLine();
                switch (tabOpened)
                {
                    case "Facebook":
                        {
                            salary -= 150;
                            break;
                        }
                    case "Instagram":
                        {
                            salary -= 100;
                            break;
                        }
                    case "Reddit":
                        {
                            salary -= 50;
                            break;
                        }
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    Environment.Exit(0);
                }
            }
            Console.WriteLine((int)salary);
        }
    }
}
