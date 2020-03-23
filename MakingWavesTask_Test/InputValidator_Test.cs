using MakingWavesTask;
using Xunit;


namespace MakingWavesTask_Test
{
    public class InputValidator_Test
    {
        private static InputValidator _inputValidator = new InputValidator();
        [Theory]
        [InlineData(null)]
        [InlineData("01012000")]
        [InlineData("01/01/2000")]
        [InlineData("32.01.2000")]
        [InlineData("01.13.2000")]
        [InlineData("lorem ipsum")]
        public void ValidationShouldFail(string value)
        {
            bool isValid = _inputValidator.Validator(value);
            Assert.True(!isValid);
        }
        [Fact]
        public void ValidationShouldPass()
        {
            string value = "01.01.2000";
            bool isValid = _inputValidator.Validator(value);
            Assert.True(isValid);
        }
    }
}

