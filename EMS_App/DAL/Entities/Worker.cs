using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Worker: Person
    {
        public int BadgeNumber { get; set; }
        public RankEnum Rank { get; set; }
        public virtual List<SpecializationEnum> Specializations { get; set; }
        public virtual List<TrainingEnum> Trainings { get; set; }
        public virtual List<WorkerPeriod> WorkTimes { get; set; }
        public WorkerPeriod TimeOff { get; set; }
    }
}
