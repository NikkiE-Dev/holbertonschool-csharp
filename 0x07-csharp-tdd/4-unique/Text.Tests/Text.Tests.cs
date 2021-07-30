using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Non_rep_first()
        {
            string test = "Hoowwdyyaall";
            int result = Text.Str.UniqueChar(test);
            Assert.AreEqual(result, 0);
        }
        [Test]
        public void Non_rep_last()
        {
            string test = "HHoowwddyyaal";
            int result = Text.Str.UniqueChar(test);
            Assert.AreEqual(result, 12);
        }
        [Test]
        public void Non_rep_mid()
        {
            string test = "HHoowwdyyaall";
            int result = Text.Str.UniqueChar(test);
            Assert.AreEqual(result, 6);
        }
        [Test]
        public void No_rep_char()
        {
            string test = "Howdy";
            int result = Text.Str.UniqueChar(test);
            Assert.AreEqual(result, 0);
        }
        [Test]
        public void Empty_string()
        {
            string test = "";
            int result = Text.Str.UniqueChar(test);
            Assert.AreEqual(result, -1);
        }
    }
}