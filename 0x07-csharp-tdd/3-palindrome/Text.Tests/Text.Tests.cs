using System;
using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Palindrome()
        {
            Assert.True(Text.Str.IsPalindrome("doggod"));
        }
         [Test]
        public void Palindrome_Upper()
        {
            Assert.True(Text.Str.IsPalindrome("Doggod"));
        }
         [Test]
        public void Palindrome_Punc()
        {
            Assert.True(Text.Str.IsPalindrome("dog:god"));
        }
         [Test]
        public void Palindrome_Space()
        {
            Assert.True(Text.Str.IsPalindrome("dog god"));
        }
         [Test]
        public void Palidrome_Empty()
        {
            Assert.True(Text.Str.IsPalindrome(""));
        }

    }
}