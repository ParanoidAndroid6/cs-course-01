using System;

namespace LitresHM
{
    class Program
    {
        enum Litres: int 
        {    
            None = 0x0,
            Litres1 = 0x1,
            Litres5 = 0x1 << 1,
            Litres20 = 0x1 << 2
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How much litres of juice do u want?: ");
            double input = Convert.ToDouble(Console.ReadLine());
            var non = Convert.ToInt16(Litres.Litres5);
            Litres lit = Litres.Litres1 | Litres.Litres5 | Litres.Litres20;
            double num20 = Convert.ToDouble(Litres.Litres20);
            double num05 = Convert.ToDouble(Litres.Litres5);
            double divide20 = input / 20;
            double divide20Smth = input % 20;
            double divided = divide20Smth / non;
            Litres divide5 = (Litres)input & Litres.Litres1;
            
            Console.WriteLine($"20 Litres: {Math.Floor(divide20)}");
            Console.WriteLine($"20% Litres: {Math.Ceiling(divide20Smth)}");
            Console.WriteLine($"20& Litres: {divide5}");
            Console.ReadKey();
        }
    } 
}
