using CalculatorSolution;

namespace TestProject2
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]
        public void Add_TwoNumbers_ReturnsSum()
        {
            // В NUnit используется Assert.That
            var result = Calculator.Add(5, 7);
            Assert.That(result, Is.EqualTo(12));
        }

        // Параметризованные тесты в NUnit делаются через TestCase
        [TestCase(10, 2, 5.0)]
        [TestCase(9, 3, 3.0)]
        public void Divide_ValidNumbers_ReturnsQuotient(int dividend, int divisor, double expected)
        {
            var result = Calculator.Divide(dividend, divisor);
            Assert.That(result, Is.EqualTo(expected).Within(0.0001));
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => Calculator.Divide(10, 0));
        }
    }
}