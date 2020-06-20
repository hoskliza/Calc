using Calc;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void TestSum()
        {
            Assert.AreEqual(5, MathOperations.Sum(2, 3));
        }

        [Test]
        public void TestSubstraction()
        {
            Assert.AreEqual(5, MathOperations.Substraction(10, 5));
        }
        
        [Test]
        public void TestDivision()
        {
            Assert.AreEqual(5, MathOperations.Division(25, 5));
        }
        
        [Test]
        public void TestMultiply()
        {
            Assert.AreEqual(5, MathOperations.Multiply(float.Parse("2.5"), 2));
        }
    }
}