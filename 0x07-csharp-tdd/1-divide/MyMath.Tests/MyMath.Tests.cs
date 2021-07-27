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
            int[,] matrix = {
                {50, 20, -20},
                {40, 548, 120},
                {88, 42, -10}
            };
            int num = 2;
            int[,] newMatrix = {
                {25, 10, -10},
                {20, 274, 60},
                {44, 21, -5}
            };
            int[,] result = MyMath.Matrix.Divide(matrix, 2);
            Assert.AreEqual(result, newMatrix);
        }

        [Test]
        public void Division_By_Zero()
        {
            int[,] matrix = {
                {50, 20, -20},
                {40, 548, 120},
                {88, 42, -10}
            };
            int num = 0;
            int[,] result = MyMath.Matrix.Divide(matrix, 0);
            Assert.IsNull(result);
        }

        [Test]
        public void Null_Matrix()
        {
            int[,] matrix = null;
            int num = 10;
            int[,] result = MyMath.Matrix.Divide(matrix, 0);
            Assert.IsNull(result);
        }
    }
}