using System;
using System.Collections.Generic;
namespace ListHM
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = true;
            Stack<char> stk = new Stack<char>();
            Console.WriteLine("Enter list of brackets:");
            var input = Console.ReadLine();
            char current, previous;
            for (int i = 0; i < input.Length; i++)
            {
                current = input[i];

                if (current == '(' || current == '[' || current == '{')
                {
                    stk.Push(current);
                }
                else if (current == ')' || current == ']' || current == '}')
                {
                    if (stk.Count == 0)
                    {
                        result = false;
                    }

                    else
                    {
                        previous = stk.Peek();
                        if ((current == ')' && previous == '(') || (current == ']' && previous == '[') || (current == '}' && previous == '{'))
                        {
                            stk.Pop();
                        }
                        else
                        {
                            result = false;
                        }
                    }
                }
            }
            Console.WriteLine(result);
            Console.ReadKey();
          
        }
    }
}