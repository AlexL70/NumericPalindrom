using System;

namespace Palindromes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            for (int i = 0; i < 10000; i++)
            {
                if (IsPalindrome(i))
                {
                    sum += i;
                }
            }
            Console.WriteLine($"The sum of all numeric palindromes that are less than 10,000 is {sum}");
        }

        private static bool IsPalindrome(int num)
        {
            string s = num.ToString();
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i -1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
