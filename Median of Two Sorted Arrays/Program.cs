using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {

        public static double MedianOfTwoArrays(int[] firstArr, int[] secondArr)
        {
            double temp;

            var workList = new List<int>();

            workList.AddRange(firstArr);

            workList.AddRange(secondArr);

            workList.Sort();

            if (workList.Count % 2 == 0)
            {
                return (double)(workList[workList.Count / 2 - 1] +
                                workList[workList.Count / 2 - 1] + 1) / 2;
            }
            else
            {
                temp = Math.Round((double)workList.Count / 2) - 1;

                return workList[Convert.ToInt32(temp)];
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 }, array2 = { 4, 5, 6 };

            Console.WriteLine(MedianOfTwoArrays(array, array2));
        }
    }
}
