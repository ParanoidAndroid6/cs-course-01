using System;

namespace SamRabota
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "    lorem   ipsum   dolor  sit    amet   ";
            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] wordss = text.Split(' ');
            words[1] = words[1].ToUpper();
            var result1 = string.Join(' ', words);
            Console.WriteLine(result1);

            string text2 = text.TrimEnd();
            int i = text2.LastIndexOf(' ');
            text2 = text2.Substring(0, i);
            text2 = text2.TrimEnd();
            Console.WriteLine(text2);
            Console.ReadKey();
        }
    }
}
