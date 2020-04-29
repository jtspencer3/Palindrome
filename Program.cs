using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("racecar"));
            Console.WriteLine(IsPalindrome("racecars"));             
        }

        static string Reverse(string reverseString)
        {
            string Reversed = "";

            for (int i = 0; i < reverseString.Length; i++)
            {
                Reversed = String.Concat(reverseString[i], Reversed);
            }

            return Reversed;
        }

        static bool IsPalindrome(string input)
        {
            string Reversed = Reverse(input);

            bool isPalindrome = false;

            if(Reversed == input)
            {
                isPalindrome = true;
            }

            return isPalindrome;            
        }
    }
}
