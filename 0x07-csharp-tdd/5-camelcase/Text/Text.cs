using System;
using System.Collections.Generic;


namespace Text
{
    ///<summary>Creates a public class.</summary>
    public class Str
    {
        ///<summary>Creates a protype.</summary>
        public static int CamelCase(string s)
        {
            int count = 0, idx = 0;

            while (index < s.Length && char.IsWhiteSpace(s[idx]))
                idx++;

            while (idx < s.Length)
            {
                while (idx < s.Length && !char.IsWhiteSpace(s[idx]))
                    idx++;

                count++;


                while (idx < s.Length && char.IsWhiteSpace(s[idx]))
                    idx++;
            }
        }
    }
}
