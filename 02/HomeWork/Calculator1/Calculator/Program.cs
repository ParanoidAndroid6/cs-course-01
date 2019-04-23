using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
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
            Console.WriteLine($"Сумма:{number01 + number02}");
            Console.WriteLine($"Разница:{number01 - number02}");
            Console.WriteLine($"Умножение:{number02 * number01}");
            Console.WriteLine($"Степень:{Math.Pow(number01, number02)}");
            Console.WriteLine($"Деление с остатком:{number001 % number002}");
            Console.ReadKey();
        }
    }
}
