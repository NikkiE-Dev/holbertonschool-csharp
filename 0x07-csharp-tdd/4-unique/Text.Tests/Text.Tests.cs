using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void Non_rep_first()
        {
            string test = "Howdyyall";
            int result = Text.Str.UniqueChar(test);
            Assert.Equals(result, 0);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}