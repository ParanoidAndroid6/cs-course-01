using System;

namespace Work1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter minimum two words:");
                var input = Console.ReadLine();
                string[] i = input.Split(' ');
                var u = 0;
               foreach(string o in i)
                {
                   if (i.Length == 1)
                    {
                        Console.WriteLine("Error! Enter minimum two words please");
                        break;
                    }
                  
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
            catch(FormatException)
            {
                Console.WriteLine("Error! Enter words, please");
            }
            Console.ReadKey();
        }
    }
}
