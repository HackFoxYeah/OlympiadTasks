using System;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        class DanceTask
        {
            public string Name { get; set; }
            public int Score { get; set; }

            public static DanceTask operator +(DanceTask a, DanceTask b)
            {
                string name = a.Name + " & " + b.Name;

                int score = a.Score + b.Score;

                DanceTask res = new DanceTask
                {
                    Name = name,

                    Score = score
                };

                return res;
            }
        }

        static void Main(string[] args)
        {
            DanceTask first = new DanceTask { Name = Console.ReadLine(), Score = Convert.ToInt32(Console.ReadLine()) };

            DanceTask second = new DanceTask { Name = Console.ReadLine(), Score = Convert.ToInt32(Console.ReadLine()) };

            DanceTask third = first + second;

            Console.WriteLine(third.Name + "\n" + third.Score);

            Console.ReadKey();
        }
    }
}
