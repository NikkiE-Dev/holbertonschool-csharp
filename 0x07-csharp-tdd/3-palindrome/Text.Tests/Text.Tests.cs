using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Palidrome()
        {
            string text = "level";
            string textrev = Text.Str.IsPalindrome(text);
            Assert.AreSame(text, textrev);

        }

    }
}