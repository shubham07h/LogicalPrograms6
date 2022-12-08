using System;
class Program
{
    public static void Main(string[] args)
    {

         int ReverseNumber(int n)
        {
            int reverse = 0;

            while (n > 0)
            {
                int remainder = n % 10;
                reverse = (reverse * 10) + remainder;
                n /= 10;
            }

            return reverse;
        }
    }
}