using System.Collections.Generic;

namespace DataAccessLayer.Entities
{
    public class Employee: Person
    {
        public int BadgeNumber { get; set; }
        public int Rank { get; set; }
        public virtual List<int> Specializations { get; set; }
        public virtual List<int> Trainings { get; set; }
        public virtual List<EmployeePeriod> WorkTimes { get; set; }
        public EmployeePeriod TimeOff { get; set; }
    }
}
