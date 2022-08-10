using System;
namespace ConsoleApp1
{
      /*<summary>
      
       Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

       You may assume that each input would have exactly one solution, and you may not use the same element twice.

       You can return the answer in any order.
       
      <summary>*/

    internal class Program
    {

        public static int[] TwoSum(int[] array, int target)
        {
            int temp;
                      
            var list = new List<int>();

            list.AddRange(array);

            for (int i = 0; i < list.Count; i++)
            {
                temp = target - array[i];

                if (list.Contains(temp) && Array.IndexOf(array, temp) != i)
                {
                    return new int[] { Array.IndexOf(array, temp), i };
                }
            }

            return null;
        }        
    }
}
