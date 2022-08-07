using System;
namespace ConsoleApp1
{

      /*<summary>
       учитывая массив целых чисел nums и целочисленное целевое значение, верните индексы двух чисел таким образом,
       чтобы они складывались в целевое значение.
       вы можете предположить, что каждый ввод будет иметь ровно одно решение.
       вы можете вернуть ответ в любом порядке.
      <summary>*/

    internal class Program
    {

        public static int[] PairOfNumber(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] + array[j] == value)
                    {
                        return new int[2] { array[i], array[j] };
                    }
                }
            }
            return new int[1] { 0 };
        }

        static void Main(string[] args)
        {
            int[] array = { 5, 1, 3 },
                  array_2 = PairOfNumber(array, 4);

            Console.Write($"[{array_2[0]},{array_2[1]}]\n");
        }
    }
}
