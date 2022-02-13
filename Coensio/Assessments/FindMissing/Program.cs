using System;

namespace FindMissing
{
    class Program
    {
        public static int findMissing(int[] nums)
        {
            int miss = 0;

            Array.Sort<int>(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (((i + 1) != nums.Length) && ((nums[i] + 2) != (nums[i + 1])))
                {
                    miss = nums[i] + 2;
                    break;
                }
            }

            return miss;
        }

        static void Main(string[] args)
        {
            int[] nums = { 9, 7, 3 };

            Console.WriteLine(findMissing(nums));
        }
    }
}
