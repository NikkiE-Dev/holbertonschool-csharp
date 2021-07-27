using System;
using System.Linq;
using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Max_Int()
        {
            List<int> nums = (18, 24, 50, 2, 128, 64);
            int max = 128;
            int result = MyMath.Operations.Max(nums);
            Assert.AreEqual(result, max);
        }

        [Test]
        public void Empty_List()
        {
            List<int> nums = newList<int>();
            int max = 0;
            int result = MyMath.Operations.Max(nums);
            Assert.AreEqual(result, max);
        }
    }
}