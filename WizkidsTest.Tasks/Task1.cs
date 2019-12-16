using System;
using System.Collections.Generic;
using System.Text;

namespace WizkidsTest.Tasks
{
    public class Task1
    {
        /// <summary>
        /// Checks if the input string is palindrome or not
        /// </summary>
        /// <param name="input">String to be compared</param>
        /// <returns></returns>
        public static bool IsPalindrome(string input)
        {
            string reversedInput = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedInput += input[i];
            }

            return input.Equals(reversedInput);
        }
    }
}
