public static class Solution
{
    //exercise 1:
    //Given a signed 32-bit integer x, return x with its digits reversed.
    //If reversing x causes the value to go outside the signed 32-bit integer range [-2^31, 2^31 - 1], then return 0.
    public static int Reverse(int x)
    {

        int reverse = 0;
        while (x != 0)
        {
            int ostatok = x % 10;
            if ((long)reverse * 10 + ostatok > Int32.MaxValue || (long)reverse * 10 + ostatok < Int32.MinValue)
            {
                return 0;
            }
            reverse = (reverse * 10) + ostatok;
            x /= 10;
        }
        return reverse;
    }
    //exercise 2:
    //Given an array of integers nums and an integer target,
    ///return indices of the two numbers such that they add up to target.
    //You may assume that each input would have exactly one solution,
    //and you may not use the same element twice.
    //You can return the answer in any order.
    public static int[] TwoSum(int[] nums, int target)
    {
        int[] indexesOfValues = new int[2];
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    indexesOfValues[0] = i;
                    indexesOfValues[1] = j;
                }
            }
        }
        return indexesOfValues;
    }

}
