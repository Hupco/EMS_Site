using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class WorkerPeriod: Period
    {
        public Guid WorkerId { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
