using System;

namespace LogicLayer.Models
{
    public class Period
    {
        public Guid Id { get; private set; }
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }

        public Period(Guid id, DateTime start, DateTime end)
        {
            Id = id;
            Start = start;
            End = end;
        }

        public Period()
        {
            Id = new Guid();
        }
    }
}
