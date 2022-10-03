Console.WriteLine(Solution.RomanToInt("MCMXCIV"));
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
//exercise 3:
//Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
//For example, 2 is written as II in Roman numeral, just two ones added together. 
//12 is written as XII, which is simply X + II.The number 27 is written as XXVII, which is XX + V + II.
//Roman numerals are usually written largest to smallest from left to right.
//However, the numeral for four is not IIII. Instead, the number four is written as IV.
//Because the one is before the five we subtract it making four.
//same principle applies to the number nine, which is written as IX.There are six instances where subtraction is used:
//I can be placed before V(5) and X(10) to make 4 and 9. 
//X can be placed before L(50) and C(100) to make 40 and 90. 
//C can be placed before D(500) and M(1000) to make 400 and 900.
    public static int RomanToInt(string s)
    {
        int result = 0;
        int y = 0;
        Dictionary<string, int> a = new Dictionary<string, int>();
        a.Add("I", 1);
        a.Add("V", 5);
        a.Add("X", 10);
        a.Add("L", 50);
        a.Add("C", 100);
        a.Add("D", 500);
        a.Add("M", 1000);

        foreach(char i in s.ToCharArray())
        {
            int aa;
            a.TryGetValue(i.ToString(), out aa);

            if (y == 1 && (aa == 5||aa == 10))
            {
                result += aa-y*2; 
            }
            else if (y == 10 && (aa == 50 || aa == 100))
            {
                result += aa - y * 2;
            }
            else if (y == 100 && (aa == 500 || aa == 1000))
            {
                result += aa - y * 2;
            }
            else
            {
                result += aa;
            }
            y = aa;
        }
        return result;
    }

}
