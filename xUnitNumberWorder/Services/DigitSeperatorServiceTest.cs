using NumberWorder.Abstract;
using NumberWorder.Services;
using Xunit;

namespace xUnitNumberWorder.Services
{
    public class DigitSeperatorServiceTest
    {
        [Fact]
        public void Check_four_digits()
        {
            // Arrange
            int fourDigits = 1234;
            IDigitSeperatorService digitSeperatorService = new DigitSeperatorService();

            //Act
            var result = digitSeperatorService.GetIntArray(fourDigits);

            //Assert
            Assert.True(result.Length > 0);
            Assert.True(result[0] == 1);
            Assert.True(result[1] == 2);
            Assert.True(result[2] == 3);
            Assert.True(result[3] == 4);
        }

        [Fact]
        public void Check_four_some_randome_digits()
        {
            // Arrange
            int fourDigits = 1345667;
            IDigitSeperatorService digitSeperatorService = new DigitSeperatorService();

            //Act
            var result = digitSeperatorService.GetIntArray(fourDigits);

            //Assert
            Assert.True(result.Length > 0);
            Assert.True(result[0] == 1);
            Assert.True(result[1] == 2);
            Assert.True(result[2] == 3);
            Assert.True(result[3] == 4);
        }
    }
}
