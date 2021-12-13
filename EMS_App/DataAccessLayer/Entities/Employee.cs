using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
