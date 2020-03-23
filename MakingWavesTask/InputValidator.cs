using System;
using System.Globalization;

namespace MakingWavesTask
{
    public class InputValidator
    {
        private const string dateFormat = "dd.MM.yyyy";
        public bool Validator(string input)
        {
            return DateTime.TryParseExact(input, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
        }
    }
}
