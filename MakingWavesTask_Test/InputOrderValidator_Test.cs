using MakingWavesTask;
using System;
using Xunit;

namespace MakingWavesTask_Test
{
    public class InputOrderValidator_Test
    {
        private static InputOrderValidator _inputOrderValidator = new InputOrderValidator();
        [Fact]
        public void ValidationShouldPass()
        {
            DateTime firstDate = new DateTime(2000, 01, 01);
            DateTime secondDate = new DateTime(2000, 01, 02);
            bool dateValidator = _inputOrderValidator.Order(firstDate, secondDate);
            Assert.True(dateValidator);
        }
        [Fact]
        public void ValidationShouldFail()
        {
            DateTime firstDate = new DateTime(2000, 01, 02);
            DateTime secondDate = new DateTime(2000, 01, 01);
            bool dateValidator = _inputOrderValidator.Order(firstDate, secondDate);
            Assert.True(!dateValidator);
        }
    }
}
