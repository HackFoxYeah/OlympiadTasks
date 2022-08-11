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
            for (int i = 1; i < array.Length; i++)
            {
                array[i] += array[i - 1];
            }

            return array;
        }       
    }
}
