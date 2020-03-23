using MakingWavesTask;
using System;
using Xunit;

namespace MakingWavesTask_Test
{
    public class InputConverter_Test
    {
        private static InputConverter _inputConverter = new InputConverter();
        [Fact]
        public void ConvertStringToDate()
        {
            string date = "01.01.2000";
            DateTime expectedResult = new DateTime(2000, 01, 01);
            DateTime outputDate = _inputConverter.Converter(date);
            Assert.Equal(outputDate, expectedResult);
        }
        [Fact]
        public void ConvertStringToDateInProperFormat()
        {
            string date = "01.01.2000";
            DateTime outputDate = _inputConverter.Converter(date);
            string outputStringDate = $"{outputDate.ToString("dd.MM.yyyy")}";
            Assert.Equal(outputStringDate, date);
        }
    }
}
