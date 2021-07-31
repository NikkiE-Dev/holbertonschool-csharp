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
            if (s == null || s.Legnth == 0)
                return (0);
            
            int count = 1, idx = 0;
            
            while (idx < s.Length)
            {
                if (char.IsUpper(s[idx]))
                {
                    idx++;
                    count++;
                }
                idx++;
            }
            return count;
        }
    }
}
