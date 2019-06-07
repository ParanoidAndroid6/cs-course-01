using System;

namespace HM10
{
    class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int AgeInFourYears
            {
                get { return Age + 4; }
            }
            public string Final
            {
                get { return $"Name: {Name}, age  in four yeras: {AgeInFourYears}"; }
            }
        }
        static void Main(string[] args)
        {
            var people = new Person[3];
            for (var i = 0; i < people.Length; i++)
            {
                people[i] = new Person();
                Console.Write($"Write a name for {i} candidate: ");
                people[i].Name = Console.ReadLine();
                Console.Write($"Write an age for {i} candidate: ");
                people[i].Age = int.Parse(Console.ReadLine());
            }

            foreach (var p in people)
            {
                Console.WriteLine(p.Final);
            }
            
            Console.ReadKey();
        }
        
    }
}
