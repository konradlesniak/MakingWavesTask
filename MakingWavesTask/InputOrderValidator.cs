using System;

namespace MakingWavesTask
{
    public class InputOrderValidator
    {
        public bool Order(DateTime firstDate, DateTime secondDate)
        {
            if (secondDate.CompareTo(firstDate) <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
