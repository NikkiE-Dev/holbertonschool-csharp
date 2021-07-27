using System;
using System.Linq;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>Creates a public class named Operations.</summary>
    public class Operations
    {
        /// <summary>Creates a protype that finds Max Integer.</summary>
        public static int Max(List<int> nums)
        {
            int result = 0;
            if (nums.Count == 0 || nums == null)
            {
                return 0;
            }
            result = nums.Max();
            return (result);
        }
    }
}
