using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class Wordsmith
    {
        public bool IsApalindrome(string word)
        {
            var reverded = "";
            for (int i =  word.Length-1;i>=0; i--)
            {
                reverded += word[i];
            }
            if (reverded == word)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
