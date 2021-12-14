using System;

namespace DataAccessLayer.Entities
{
    public class EmployeePeriod: Period
    {
        public Guid WorkerId { get; set; }
        public virtual Employee Worker { get; set; }
    }
}
