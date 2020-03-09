using NUnit.Framework;
using Program = TravisCITest.Program;

namespace TravisCIUnitTest
{
    public class Tests
    {
        [TestCase(1, 1, 2)]
        [TestCase(-5, 5, 0)]
        public void Add_ReturnTrue(int num1, int num2, int expected)
        {
            var actual = Program.Add(num1, num2);
            
            Assert.AreEqual(actual, expected);
        }
        
        [TestCase(1, 1, 0)]
        [TestCase(-5, 5, -10)]
        public void Min_ReturnTrue(int num1, int num2, int expected)
        {
            var actual = Program.Min(num1, num2);
            
            Assert.AreEqual(actual, expected);
        }
        
        [TestCase(1, 1, 1)]
        [TestCase(-5, 5, -25)]
        [TestCase(-0, 0, -0)]
        public void Multiply_ReturnTrue(int num1, int num2, int expected)
        {
            var actual = Program.Multiply(num1, num2);
            
            Assert.AreEqual(actual, expected);
        }
        
        [TestCase(1, 1, 1)]
        [TestCase(-5, 5, -1)]
        [TestCase(100, 10, 10)]
        public void Divide_ReturnTrue(int num1, int num2, int expected)
        {
            var actual = Program.Divide(num1, num2);
            
            Assert.AreEqual(actual, expected);
        }
    }
}