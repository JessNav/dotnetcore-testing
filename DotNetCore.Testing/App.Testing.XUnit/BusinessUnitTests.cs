using App.Business;
/*
    TODO: README.md
    [Attributes]
        [Fact] is used for a test method that takes no parameters.
        [Theory] is used for a test method that takes parameters.
            - It allows you to run the same test with different data sets,
            - which can be provided using attributes like 
                - [InlineData]
                - [MemberData]
                - [ClassData]
    3 A's of Automated Testing
    - Arrange
    - Act
    - Assert
*/

namespace App.Testing.XUnit
{
    public class BusinessUnitTests
    {
        // Dependency Injection
        private readonly Algorithm Algorithm = new Algorithm();

        [Fact]
        public void Algorithm_InputZero_ReturnZero()
        {
            // Arrange
            int input = 0;
            int expected = 0;

            // Act
            int result = Algorithm.Fibonacci(input);

            // Assert
            Assert.Equal(expected, result);
        }


        
    }
}
