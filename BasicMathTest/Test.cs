using BasicMathName;
using System.Net.Http.Headers;

namespace BasicMathTest
{
    internal class Tests
    {
        private BasicMath math;

        [SetUp]
        public void Setup()
        {
            math = new BasicMath();
        }

        [Test]
        public void Test_AddMethod()
        {
            double result = this.math.Add(2, 3); // adds to 5
            Assert.AreEqual(5, result);

            result = math.Add(5, -15.5); // adds to -10.5
            Assert.AreEqual(-10.5, result);
        }

        [Test]
        public void Test_SubtractionMethod()
        {
            double result = this.math.Subtract(13, 4); // subS to 9
            Assert.AreEqual(9, result);

            result = math.Subtract(17, 34); // subS to -17
            Assert.AreEqual(-17, result);
        }

        [Test]
        public void Test_MultiplyMethod()
        {
            double result = this.math.Multiply(3, 5); // multiplies to 15
            Assert.AreEqual(15, result);

            result = math.Multiply(5, -7); // multiplies to -35
            Assert.AreEqual(-35, result);
        }

        [Test]
        public void Test_DivideMethod()
        {
            double result = this.math.Divide(15, 3); // divides to 5
            Assert.AreEqual(5, result);

            result = math.Divide(5, -20); // divides to -0.25
            Assert.AreEqual(-0.25, result);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}