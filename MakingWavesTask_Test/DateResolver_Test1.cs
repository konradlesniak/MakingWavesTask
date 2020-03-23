using MakingWavesTask;
using System;
using Xunit;

namespace MakingWavesTask_Test
{
    public class DateResolver_Test
    {
        private static DateResolver _dateResolver = new DateResolver();
        [Fact]
        public void ValidationShouldPassDay()
        {
            var value = new Period(new DateTime(2000, 01, 01), new DateTime(2000, 01, 02));
            string output = _dateResolver.dateToString(value);
            string expectedResult = "01 - 02.01.2000";
            Assert.Equal(output, expectedResult);
        }
        [Fact]
        public void ValidationShouldPassMonth()
        {
            var value = new Period(new DateTime(2000, 01, 01), new DateTime(2000, 02, 01));
            string output = _dateResolver.dateToString(value);
            string expectedResult = "01.01 - 01.02.2000";
            Assert.Equal(output, expectedResult);
        }
        [Fact]
        public void ValidationShouldPassYear()
        {
            var value = new Period(new DateTime(2000, 01, 01), new DateTime(2001, 01, 01));
            string output = _dateResolver.dateToString(value);
            string expectedResult = "01.01.2000 - 01.01.2001";
            Assert.Equal(output, expectedResult);
        }
    }
}
