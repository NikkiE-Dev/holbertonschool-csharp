using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Regular_Division()
        {
            int[,] matrix = new int[,]
            {
                {50, 25, -20},
                {40, 548, 120},
                {88, 42, -10}
            };
            int[,] result;
            result = MyMath.Matrix.Divide(matrix, 2);
            Assert.AreEqual(result, result);
        }

        [Test]
        public void Division_By_Zero()
        {
        }

        [Test]
        public void Null_Matrix()
        {
        }
    }
}