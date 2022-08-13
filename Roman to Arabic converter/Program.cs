using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        private static Dictionary<char, int> map = new Dictionary<char, int>() // создание словаря, состоящего из римских цифр
        {
            {'I', 1 },
            {'V', 5 },
            {'X', 10 },
            {'L', 50 },
            {'C', 100 },
            {'D', 500 },
            {'M', 1000 }
        };

        private static bool IsSubtractive(char c1, char c2) // функция, учитывающая порядок цифр в числе (XI / IX)
        {
            return map[c1] < map[c2];
        }

        public static int ParseToArabic(string roman)
        {
            int result = 0;

            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && IsSubtractive(roman[i], roman[i + 1])) // в случае, если левостоящая цифра меньше правой,                                                                                   
                {                                                                  // то она вычитается из результата, иначе - прибавляется
                    result -= map[roman[i]];
                }
                else
                {
                    result += map[roman[i]];
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter roman number: ");

            string roman = Console.ReadLine().ToUpper();

            int arabicNumber = ParseToArabic(roman);

            Console.WriteLine($"{roman} = " + arabicNumber);
        }
    }
}
