using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class EmployeePeriod: Period
    {
        public Guid WorkerId { get; set; }
        public virtual Employee Worker { get; set; }
    }
}
