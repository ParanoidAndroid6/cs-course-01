using System;

namespace BankHM
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var i = 0;
                var o = 0;
                while (o == 0)
                {

                    Console.WriteLine("Please, enter your deposit");
                    var input = Convert.ToDecimal(Console.ReadLine());
                    if (input < 0)
                    {
                        Console.WriteLine("Error! Enter a higher value!");
                    }
                    Console.WriteLine("Please, enter your daily % of profit");
                    var inputproc = Convert.ToDecimal(Console.ReadLine());
                    if (inputproc < 0)
                    {
                        Console.WriteLine("Error. Enter a higher value!");
                        continue;
                    }
                    Console.WriteLine("Please enter desired sum of profit");
                    var inputprof = Convert.ToDecimal(Console.ReadLine());
                    if (inputprof < 0)
                    {
                        Console.WriteLine("Error! Enter a higher value");
                        Console.ReadKey();
                    }
                    
                    var op = input * inputproc;
                    while (input < inputprof)
                    {
                        input += op;
                        i++;
                    }
                    Console.WriteLine($"Wanted sum would be available in {i} days");
                    Console.ReadKey();
                    break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error! Enter a number!");
                Console.ReadKey();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error! Enter a smaller number");
                Console.ReadKey();
            }
        }
    }
            
}  
    


        
            
          
            
        
    

