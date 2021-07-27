using System;
using System.Collections.Generic;

namespace Text
{
    ///<summary>Creates a public class.</summary>
    public class Str
    {
        ///<summary>Creates a protype.</summary>
        public static int UniqueChar(string s)
        {
            List<char> basic = new List<char>();
            Dictionary<char, int> grab = new Dictionary<char, int>();
            int a = -1;
            for (int b = 0; b < s.Length; b++)
            {
                if (basic.Contains(s[b]))
                    continue;
                if (grab.ContainsKey(s[b]))
                {
                    basic.Add(s[b]);
                    grab.Remove(s[b]);
                    continue;
                }
                grab.Add(s[b], b);
            }
            foreach (KeyValuePair<char, int> item in grab)
            {
                if (item.Value < a || a == -1)
                    a = item.Value;
            }
            return(a);
        }
    }
}
