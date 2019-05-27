using System;

namespace Work1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter minimum two words or 'exit' if you want to quit :");
                while (true)
                { 
                int u = 0;
                var input = Console.ReadLine();
                string[] i = input.Split(' ');
                    if (i.Length == 1)
                    {
                        Console.WriteLine("Error! Enter minimum two words please");
                        break;
                    }
                    foreach (string o in i)
                    {
                        if (o.StartsWith("a"))
                        {
                            u++;
                        }
                        else if (o.StartsWith("A"))
                        {
                            u++;
                        }
                    }
                    Console.WriteLine($"The count is {u}");
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Error! Enter words, please");
            }
            Console.ReadKey();
        }
    }
}
