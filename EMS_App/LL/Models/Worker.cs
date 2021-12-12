using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Models
{
    public class Worker: Person
    {
        public int BadgeNumber { get; set; }
        public RankEnum Rank { get; set; }
        public List<SpecializationEnum> Specializations { get; set; }
        public List<TrainingEnum> Trainings { get; set; }
        public List<Period> WorkTimes { get; set; }
        public Period TimeOff { get; set; }

        public Worker(Guid id, string firstName, string lastName, int phoneNumber)
            : base(id, firstName, lastName, phoneNumber)
        {
        }
    }
}
