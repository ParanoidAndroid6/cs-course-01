using System;


namespace ArrayHome
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Write names of three people:");
       
            string[] names = new string[3];
            
                for (int i = 0; i < names.Length; i++)
            {
               names[i] = Console.ReadLine();
            }

            Console.WriteLine("Their age:");

            int[] age = new int[3];
            for (int i = 0; i < age.Length; i++)
            {
                age[i] = int.Parse(Console.ReadLine());   
            }
            Console.WriteLine("Name: " + names[0] + ", age in 4 years:" + (age[0] + 4));
            Console.WriteLine("Name: " + names[1] + ", age in 4 years:" + (age[1] + 4));
            Console.WriteLine("Name: " + names[2] + ", age in 4 years:" + (age[2] + 4));



            Console.ReadKey();
        }
    }
} 
