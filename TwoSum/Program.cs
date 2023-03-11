using System;

namespace TwoSum
{

    public class TwoSumLeetCode
    {
        public static int[] TwoSum(int[] nums, int target)
        {

            int length = nums.Length;

            if(nums == null || length <2)
            {
                return Array.Empty<int>();
            }

            Dictionary<int, int> result = new Dictionary<int, int>();


            for (int i = 0; i< length; i++)
            {
                int FirstNum = nums[i];
                int SecondNum = target - FirstNum;

                if(result.ContainsKey(SecondNum))
                {
                    //return new [] { result[SecondNum], i };
                }

                if(result.TryGetValue(SecondNum, out int index))
                {
                    return new int[] { index, i };
                }
                //result.Add(FirstNum, i);
                result[FirstNum] = i;
            }


            return Array.Empty<int>();
        }

        public static void Main()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 17;
            int[] result = TwoSum(nums, target);
            Console.WriteLine(string.Join("",result));
            Console.ReadLine();
        }

    }
}