namespace _02.Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string input;
            do
            {
                input = Console.ReadLine();

            } while (input != password);
            Console.WriteLine($"Welcome {username}!");
        }
    }
}
