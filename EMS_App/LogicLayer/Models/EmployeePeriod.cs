using System;

namespace LogicLayer.Models
{
    public class EmployeePeriod : Period
    {
        public Guid WorkerId { get; private set; }

        public EmployeePeriod(): base()
        {
            WorkerId = new Guid();
        }

        public EmployeePeriod(Guid id, Guid workerId, DateTime start, DateTime end) : base(id, start, end)
        {
            WorkerId = workerId;
        }
    }
}
