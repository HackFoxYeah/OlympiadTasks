namespace ConsoleApp1
{
    /*<summary>
     Input: nums = [1,7,3,6,5,6]
     Output: 3
     Explanation:
     The pivot index is 3.
     Left sum = nums[0] + nums[1] + nums[2] = 1 + 7 + 3 = 11
     Right sum = nums[4] + nums[5] = 5 + 6 = 11
    <summary>*/

    internal class Program
    {
        public static int GetPivotIndex(int[] array)
        {
            int sum = 0, leftSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (leftSum == sum - leftSum - array[i]) return i;
                leftSum += array[i];
            }

            return -1;
        }              
    }
}
