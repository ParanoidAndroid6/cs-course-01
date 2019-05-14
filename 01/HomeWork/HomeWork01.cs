using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Thread.Sleep(5000); 
            Console.WriteLine("Hello World!");
            Thread.Sleep(5000);
            Console.WriteLine("Bye!");
            Console.ReadLine();
  }
 }
}
