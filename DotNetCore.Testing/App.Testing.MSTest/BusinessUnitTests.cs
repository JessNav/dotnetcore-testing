using App.Business;
/*
    TODO: README.md
    [MSTest Attributes]
        [TestClass]
        [TestMethod]
    3 A's of Automated Testing
    - Arrange
    - Act
    - Assert
*/

namespace App.Testing.MSTest
{
    [TestClass]
    public class BusinessUnitTests
    {
        // Dependency Injection
        private readonly Algorithm _algorithm;

        public BusinessUnitTests()
        {
            _algorithm = new Algorithm();
        }

        [TestMethod]
        public void Algorithm_InputZero_ExpectedZero()
        {
            // Arrange
            int input = 0;
            int expected = 0;

            // Act
            int result = _algorithm.Fibonacci(input);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
