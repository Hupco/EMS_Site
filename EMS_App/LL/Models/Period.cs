using System;

namespace LogicLayer.Models
{
    public class Period
    {
        public Guid Id { get; private set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Period(Guid id)
        {
            Id = id;
        }

        public Period()
        {
            Id = new Guid();
        }
    }
}
