using System;

namespace ReversWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter minimum one word:");
            while (true)
            {
                var word = Console.ReadLine();
                if (word == "")
                {
                    Console.WriteLine("Error! Enter something!");
                    continue;
                }
                char[] wordReverse = word.ToCharArray();
                Array.Reverse(wordReverse);
                word = new string(wordReverse);
                Console.WriteLine(word.ToLower());
                Console.ReadKey();
            }
            
        }
    }
}
