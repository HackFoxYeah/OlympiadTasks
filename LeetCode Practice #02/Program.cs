using System;
using System.Collections.Generic;

namespace ConsoleApp1
{

    /*<summary>
     Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]). 
     Return the running sum of nums.
    <summary>*/

    internal class Program
    {
        public static int[] RunningSum(int[] array)
        {
            int temp;

            int[] arr_copy = new int[array.Length];             

            for (int i = 0; i < array.Length; i++)
            {                
                temp = 0;

                for (int j = 0; j <= i; j++)
                {
                    temp += array[j];
                }

                arr_copy[i] = temp;
            }           
            return arr_copy;
        }

        static void Main(string[] args)
        {
            int[] testArr = { 1, 2, 3, 4, 5 };

            int[] arrResult = RunningSum(testArr);

            Console.Write("[");

            for (int i = 0; i < arrResult.Length; i++)
            {
                if (i == arrResult.Length - 1)
                {
                    Console.Write(arrResult[i] + "]\n");
                }

                else
                {
                    Console.Write(arrResult[i] + ", ");
                }
            }
        }
    }
}
