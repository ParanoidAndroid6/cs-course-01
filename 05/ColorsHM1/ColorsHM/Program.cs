using System;

namespace ColorsHM
{
    class Program
    { enum Figures : short
        { None = 0,
            Circle,
            Triangle,
            Rectangle,

        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the type of figure - 1 Circle, 2 Triangle, 3 Rectangle: ");
                var input = (Figures)Enum.Parse(typeof(Figures), Console.ReadLine());
                var i = (int)input;

                switch (input)
                {
                    case Figures.Circle:
                        Console.WriteLine("Please, set the diametre: ");
                        var diam = Convert.ToInt16(Console.ReadLine());
                        var circCal = Math.Sqrt(diam) * 3.1415;
                        Console.WriteLine($"S: {circCal}");
                        Console.WriteLine($"P: {diam * (2 * 3.1415)}");
                        break;

                    case Figures.Triangle:
                        Console.WriteLine("Please set the side lenghth: ");
                        var side = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Please set the height: ");
                        var h = Convert.ToInt16(Console.ReadLine());
                        var sideCal = (h * side) / 2;
                        Console.WriteLine($"S: {sideCal}");
                        Console.WriteLine($"P: {side * 3}");
                        break;


                    case Figures.Rectangle:
                        Console.WriteLine("Please set the side lenghth: ");
                        var side2 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Please set the width: ");
                        var wide = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine($"S: {side2 * wide}");
                        Console.WriteLine($"P: {(side2 + wide) * 2}");
                        break;
                }

                
            }
            catch (FormatException)
            {
                Console.WriteLine("Error. You need to set a number");
            }
            Console.ReadKey();
        }
    } }

