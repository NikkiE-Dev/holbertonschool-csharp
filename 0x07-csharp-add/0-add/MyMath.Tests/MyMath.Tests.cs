using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Positive_Integers()
        {
            
            int a = 50;
            int b = 75;
            int c = MyMath.Operations.Add(a, b);
            Assert.AreEqual(a + b, c);
        }
        [Test]
        public void Negative_Integers()
        {
            
            int a = -50;
            int b = -25;
            int c = MyMath.Operations.Add(a, b);
            Assert.AreEqual(a + b, c);
        }
        [Test]
        public void Negative_Positive_Integers()
        {
            
            int a = 100;
            int b = -20;
            int c = MyMath.Operations.Add(a, b);
            Assert.AreEqual(a + b, c);
        }
    }
}