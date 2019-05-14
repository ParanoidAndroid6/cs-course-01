using System;

namespace HMCycle
{
    class Program
    {
        static void Main(string[] args)
        {
            var marks = new[]
            {
              new[]{2,5,4,2},
              new[]{3,3,4,5},
              new[]{5,5,4,2},
              new[]{2,2,3},
              null
          };
            var totalsum = 0;
            var goals = 0;
            for (var i = 0; i < marks.Length; i++)
            {
                if(marks[i] == null)
                {
                    Console.WriteLine("N/A");
                    continue;
                }
                var dailysum = 0;
                for (var d = 0; d < marks[i].Length; d++)
                {
                    dailysum += marks[i][d];
                }
                Console.WriteLine($"The day {i} average mark is {dailysum / marks[i].Length}");
                totalsum += dailysum;
                goals += marks[i].Length;
            }
            Console.WriteLine($"Average mark for the week is {totalsum / goals}");

          Console.ReadKey();
        }
    }
}
