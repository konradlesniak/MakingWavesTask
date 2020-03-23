using System;

namespace MakingWavesTask
{
    public class Period
    {
        public DateTime Begin { get; private set; }
        public DateTime End { get; private set; }

        public Period(DateTime begin, DateTime end)
        {
            this.Begin = begin;
            this.End = end;
        }
    }
}