using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {

        public bool IsAPalindrome(string word)
        {
            string lowerCase = word.ToLower();
            var charArr = lowerCase.ToCharArray();
            var reverse = charArr.Reverse();
            bool isPalindrome = lowerCase.SequenceEqual(reverse);
            return isPalindrome;

        }
    }
}
