using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            var num01 = Console.ReadLine();
            int number01 = int.Parse(num01);
            Console.WriteLine("Введите второе число:");
            var num02 = Console.ReadLine();
            int number02 = int.Parse(num02);
            Console.WriteLine("Введите знак операции:");
            var op = Console.ReadLine();
            if (op == "+")
            {
                Console.WriteLine(number01 + number02);
            }

            else if (op == "-")
            {
                Console.WriteLine(number01 - number02);
            } 
            
            else if (op == "*")
            {
                Console.WriteLine(number01 * number02);
            }
            else if (op == "/")
            {
                Console.WriteLine(number01 / number02);
            }
            else if (op == "%")
            {
                Console.WriteLine(number01 % number02);
            }
            else if (op == "^")
            {
                Console.WriteLine(Math.Pow(number01, number02));
            }
            Console.ReadKey();
        }
    }
}
