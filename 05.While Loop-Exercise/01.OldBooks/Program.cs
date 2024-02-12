namespace _01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            bool isBookFound = false;
            int counter = 0;
            string nextBook = Console.ReadLine();
            while (nextBook != "No More Books")
            {
                if (nextBook == favouriteBook)
                {
                    isBookFound = true;
                    break;
                }
                counter++;
                nextBook = Console.ReadLine();                
            }
            if (isBookFound == true)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
