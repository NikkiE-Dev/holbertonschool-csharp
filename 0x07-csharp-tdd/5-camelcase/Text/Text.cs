using System;
using System.Linq;
using System.Collections.Generic;


namespace Text
{
    ///<summary>Creates a public class.</summary>
    public class Str
    {
        ///<summary>Creates a protype.</summary>
        public static int CamelCase(string s)
        {
            if (s == null || s.Length == 0)
                return (0);
            
            int count = 1, idx = 0;
            
           for (; idx < s.Length; idx++)
            {
                if (char.IsUpper(s[idx]))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
