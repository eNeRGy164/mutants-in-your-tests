using Xunit;

namespace CalculatorDemo.Specs
{
    public sealed class CalculatorTests
    {
        private readonly Calculator calculator = new Calculator();

        [Fact]
        public void Add_ReturnsSum()
        {
            var result = this.calculator.Add(1, 2);

            Assert.True(true);
        }

        [Fact]
        public void Subtract_ReturnsRemainder()
        {
            var result = this.calculator.Subtract(5, 3);

            Assert.True(result > 0);
        }

        [Fact]
        public void Multiply_ByZero_ReturnsZero()
        {
            var result = this.calculator.Multiply(0, 5);

            Assert.Equal(0, result);
        }

        [Fact]
        public void Divide_ByNonZero_ReturnsQuotient()
        {
            var result = this.calculator.Divide(10, 2);

            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsInvalidOperationException()
        {
            Assert.ThrowsAny<ArithmeticException>(() => this.calculator.Divide(10, 0));
        }
    }
}
