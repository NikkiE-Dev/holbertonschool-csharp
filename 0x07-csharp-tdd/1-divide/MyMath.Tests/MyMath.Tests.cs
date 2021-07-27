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
            int i, j;
            result = MyMath.Matrix.Divide(matrix, 2);
            if (result != null)
            {
                for (i = 0; i < result.GetLength(0); i++)
                {
                    for (j = 0; j < result.GetLength(1); j++)
                    {
                        Console.Write(result[i,j] + " ");
                    }
                    Console.WriteLine();
                }
            }
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