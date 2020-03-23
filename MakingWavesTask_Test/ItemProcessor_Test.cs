using MakingWavesTask;
using System;
using Xunit;

namespace MakingWavesTask_Test
{
    public class ItemProcessor_Test
    {
        private static InputProcessor _inputProcessor = new InputProcessor();
        [Fact]
        public void ValidationShouldPass()
        {
            string[] value = { "01.01.2000", "02.01.2000" };
            var expectedResult = new Period(new DateTime(2000, 01, 01), new DateTime(2000, 01, 02));
            var output = _inputProcessor.ProcessInput(value);
            Period.Equals(expectedResult, output);
        }
    }
}
