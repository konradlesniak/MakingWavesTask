using MakingWavesTask;
using Xunit;

namespace MakingWavesTask_Test
{
    public class InputQuantityValidator_Test
    {
        private static InputQuantityValidator _inputQuantityValidator = new InputQuantityValidator();
        [Fact]
        public void ValidationShouldPass()
        {
            string[] value = new string[2];
            bool isValid = _inputQuantityValidator.QuantityOfArgs(value);
            Assert.True(isValid);
        }
        [Theory]
        [InlineData("01.01.2000")]
        [InlineData("01.01.2000", "01.01.2000", "01.01.2000")]
        public void ValidationShouldFail(params string[] value)
        {
            bool isValid = _inputQuantityValidator.QuantityOfArgs(value);
            Assert.True(!isValid);
        }
    }
}
