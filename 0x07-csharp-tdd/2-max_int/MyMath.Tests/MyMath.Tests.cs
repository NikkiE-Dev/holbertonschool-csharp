using System;
using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Max_Int_Middle()
        {
            List<int> nums = new List<int>(){18, 24, 128, 2, 64};
            int max = 128;
            int result = MyMath.Operations.Max(nums);
            Assert.AreEqual(result, max);
        }

        [Test]
        public void Empty_List()
        {
            List<int> nums = new List<int>();
            int max = 0;
            int result = MyMath.Operations.Max(nums);
            Assert.AreEqual(result, max);
        }

        [Test]
        public void Max_Int_Neg()
        {
            List<int> nums = new List<int>(){-18, -24, -2, -64, -128};
            int max = -2;
            int result = MyMath.Operations.Max(nums);
            Assert.AreEqual(result, max);
        }
        [Test]
        public void Max_Int_Beginning()
        {
            List<int> nums = new List<int>(){128, 18, 24, 2, 64};
            int max = 128;
            int result = MyMath.Operations.Max(nums);
            Assert.AreEqual(result, max);
        }
        [Test]
        public void Max_Int_End()
        {
            List<int> nums = new List<int>(){18, 24, 2, 64, 128};
            int max = 128;
            int result = MyMath.Operations.Max(nums);
            Assert.AreEqual(result, max);
        }
        [Test]
        public void Max_INT_NULL()
        {
            List<int> nums = null;
            int result = MyMath.Operations.Max(nums);
            Assert.AreEqual(result, 0);
        }
    }
}
