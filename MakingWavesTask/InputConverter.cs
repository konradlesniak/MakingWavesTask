using System;
using System.Globalization;

namespace MakingWavesTask
{
    public class InputConverter
    {
        public DateTime Converter(string input)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            return DateTime.ParseExact(input, ("dd.MM.yyyy"), provider);
        }
    }
}
