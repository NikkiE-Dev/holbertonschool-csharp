using System;
using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void One_Word()
        {
            string test = "hey";
            int result = Text.Str.CamelCase(test);
            Assert.AreEqual(result, 1);
        }
        [Test]
        public void Two_Words()
        {
            string test = "heyYou";
            int result = Text.Str.CamelCase(test);
            Assert.AreEqual(result, 2);
        }
        [Test]
        public void Multiple_Words()
        {
            string test = "heyYouIMissYou";
            int result = Text.Str.CamelCase(test);
            Assert.AreEqual(result, 5);
        }
        [Test]
        public void Empty_string()
        {
            string test = "";
            int result = Text.Str.CamelCase(test);
            Assert.AreEqual(result, 0);
        }
    }
}