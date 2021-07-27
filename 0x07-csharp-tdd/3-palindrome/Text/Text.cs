using System;
using System.Linq;
using System.Collections.Generic;

namespace Text
{
    public class Str
    {
        public static bool IsPalindrome(string s)
        {
            List<char> basic = new List<char>();
            foreach (char item in s)
            {
                if (!Char.IsPunctuation(item) && !Char.IsWhiteSpace(item))
                {
                    basic.Add(Char.ToLower(item));
                }
            }
            if (basic.Count == 0)
                return (true);
            List<char> backwards = new List<char>(basic);
            backwards.Reverse();
            return (basic.SequenceEqual(backwards));
        }
    }
}
