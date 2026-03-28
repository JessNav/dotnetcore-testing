using System;
using System.Collections.Generic;
using System.Text;

namespace App.Testing.XUnit
{
    public class SmokeUnitTests
    {
        [Fact]
        public void FactAssertTrue_InputTrue_ReturnsTrue()
        {
            Assert.True(true);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]
        public void TheoryAssertTrue_IsOdd_ReturnsTrue(int value)
        {
            Assert.True(IsOdd(value));
        }

        // Method that checks if a number is odd
        private bool IsOdd(int value)
        {
            return value % 2 == 1;
        }
    }
}
