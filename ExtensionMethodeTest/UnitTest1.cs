using MyStringExtensions;

namespace ExtensionMethodeTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("123.45", "$123.45")] 
        [InlineData("0", "$0")]            
        [InlineData("-10.25", "-$10.25")] 
        [InlineData("5.6789", "$5.6789")] 
        [InlineData("Hello", "")]
        public void TestToCurrency(string input, string expectedOutput)
        {
            // Act
            string actualOutput = input.ToCurrency();

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}