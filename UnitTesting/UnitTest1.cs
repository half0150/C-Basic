using C_Basic;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace UnitTesting
{
    public class ProgramTest
    {
        [Fact]
        public void TestAddAndMultiply()
        {
            // Arrange
            int a = 2;
            int b = 4;
            int c = 5;
            int expected = (a + b) * c;

            // Act
            int result = basic_.AddAndMultiply(a, b, c);

            // Assert
            Assert.Equal(expected, result);
        }

       
    }
}