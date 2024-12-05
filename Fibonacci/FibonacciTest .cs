
using FluentAssertions;

namespace Fibonacci
{
    public class FibonacciShould
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 5)]
        [InlineData(6, 8)]
        [InlineData(7, 13)]
        [InlineData(8, 21)]
        [InlineData(9, 34)]
        [InlineData(10, 55)]
        [InlineData(20, 6765)]
        public void ReturnsCorrectResult_ValidInput_(int n, int expected)
        {
            var result = Fibonacci.GetFibonacci(n);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void ThrowsArgumentException_NegativeInput_()
        {
            Assert.Throws<ArgumentException>(() => Fibonacci.GetFibonacci(-1));
        }
    }
    public class Fibonacci
    {
        internal static int GetFibonacci(int position)
        {
            if (position < 0)
            {
                throw new ArgumentException("Input cannot be negative");
            }
            if (position == 0)
            {
                return 0;
            }
            else if (position == 1)
            {
                return 1;
            }
            else
            {
                int a = 0, b = 1;
                for (int i = 2; i <= position; i++)
                {
                    int temp = a + b;
                    a = b;
                    b = temp;
                }
                return b;
            }
        }
    }
}