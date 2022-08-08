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
            int leffSideSum,
                rightSideSum;

            for (int i = 0; i < array.Length; i++)
            {
                leffSideSum = rightSideSum = 0;

                if (i == 0)
                {
                    leffSideSum = 0;
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        leffSideSum += array[j];
                    }
                }

                for (int k = i + 1; k <= array.Length - 1; k++)
                {
                    rightSideSum += array[k];
                }

                if (leffSideSum == rightSideSum)
                {
                    return i;
                }
            }

            return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 7, 3, 6, 5, 6 };

            System.Console.WriteLine(GetPivotIndex(arr));
        }
    }
}
