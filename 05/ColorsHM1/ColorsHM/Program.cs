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



            Console.WriteLine("Enter the type of figure: ");
            var input = Convert.ToInt16(Console.ReadLine());

            try
            {


                if (input == 1)
                {
                    Console.WriteLine("Please, set the diametre: ");
                    var diam = Convert.ToInt16(Console.ReadLine());
                    var circCal = Math.Sqrt(diam) * 3.1415;
                    Console.WriteLine($"S: {circCal}");
                    Console.WriteLine($"P: {diam * (2 * 3.1415)}");
                }


                if (input == 2)

                {
                    Console.WriteLine("Please set the side lenghth: ");
                    var side = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Please set the height: ");
                    var h = Convert.ToInt16(Console.ReadLine());
                    var sideCal = (h * side) / 2;
                    Console.WriteLine($"S: {sideCal}");
                    Console.WriteLine($"P: {side * 3}");
                }

                if (input == 3)
                {
                    Console.WriteLine("Please set the side lenghth: ");
                    var side = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Please set the width: ");
                    var wide = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine($"S: {side * wide}");
                    Console.WriteLine($"P: {(side + wide) * 2}");
                }

                
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Error. You need to set a number");
            }
            Console.ReadKey();
        }
    } }

