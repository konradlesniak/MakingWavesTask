namespace MakingWavesTask
{
    public class DateResolver
    {
        public string dateToString(Period period)
        {
            if (period.Begin.Year != period.End.Year)
            {
                return $"{period.Begin.ToString("dd.MM.yyyy")} - {period.End.ToString("dd.MM.yyyy")}";
            }
            else if (period.Begin.Month != period.End.Month)
            {
                return $"{period.Begin.ToString("dd.MM")} - {period.End.ToString("dd.MM.yyyy")}";
            }
            else if (period.Begin.Day != period.End.Day)
            {
                return $"{period.Begin.ToString("dd")} - {period.End.ToString("dd.MM.yyyy")}";
            }
            else
            {
                return $"{period.Begin.ToString("dd.MM.yyyy")}";
            }
        }
    }
}
