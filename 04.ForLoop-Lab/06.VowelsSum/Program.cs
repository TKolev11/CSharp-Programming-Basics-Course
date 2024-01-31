namespace _06.VowelsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string input = Console.ReadLine();
            int result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                switch (c)
                {
                    case 'a':
                        {
                            result += 1;
                            break;
                        } 
                    case 'e':
                        {
                            result += 2;
                            break;
                        }
                    case 'i':
                        {
                            result += 3;
                            break;
                        }
                    case 'o':
                        {
                            result += 4;
                            break;
                        }
                    case 'u':
                        {
                            result += 5;
                            break;
                        }
                }
            }
            Console.WriteLine(result);
        }
    }
}
