
public static class Solution
{
    //exercise 1:
    //Given a signed 32-bit integer x, return x with its digits reversed.
    //If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
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

}
