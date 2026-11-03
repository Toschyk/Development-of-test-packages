using CalculatorSolution;

namespace TestProject1
{
    public class CalculatorTests
    {

        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            var result = Calculator.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Add_NegativeAndPositive_ReturnsCorrectSum()
        {
            var result = Calculator.Add(-5, 3);
            Assert.Equal(-2, result);
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            var result = Calculator.Subtract(10, 4);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            var result = Calculator.Multiply(6, 7);
            Assert.Equal(42, result);
        }

        [Fact]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            var result = Calculator.Divide(10, 2);
            Assert.Equal(5.0, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => Calculator.Divide(10, 0));
        }

        // ---------- Параметризованные тесты (Theory) ----------

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 1, 2)]
        [InlineData(-1, -1, -2)]
        [InlineData(int.MaxValue, 0, int.MaxValue)]
        public void Add_Parameterized_ReturnsExpected(int a, int b, int expected)
        {
            Assert.Equal(expected, Calculator.Add(a, b));
        }

        [Theory]
        [InlineData(10, 2, 5.0)]
        [InlineData(9, 3, 3.0)]
        [InlineData(1, 4, 0.25)]
        public void Divide_Parameterized_ReturnsExpected(int dividend, int divisor, double expected)
        {
            Assert.Equal(expected, Calculator.Divide(dividend, divisor), precision: 10);
        }

        // ---------- Граничные случаи ----------

        [Fact]
        public void Add_IntegerOverflow_WrapsAround()
        {
            var result = Calculator.Add(int.MaxValue, 1);
            Assert.Equal(int.MinValue, result);
        }

        [Fact]
        public void Multiply_ByZero_ReturnsZero()
        {
            Assert.Equal(0, Calculator.Multiply(12345, 0));
        }
    }
}