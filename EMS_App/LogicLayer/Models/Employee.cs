using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicLayer.Models
{
    public class Employee: Person
    {
        public int BadgeNumber { get; set; }
        public Rank Rank { get; set; }
        public List<Specialization> Specializations { get; set; }
        public List<Training> Trainings { get; set; }
        public List<EmployeePeriod> WorkTime { get; set; }
        public EmployeePeriod TimeOff { get; set; }

        public Employee(Guid id, string firstName, string lastName, int phoneNumber)
            : base(id, firstName, lastName, phoneNumber)
        {
        }

        public Employee(Guid id, string firstName, string lastName,
            int phoneNumber, int badgeNumber, Rank rank, List<Specialization> specializations,
            List<Training> trainings ,List<EmployeePeriod> workTime, EmployeePeriod timeOff)
            : base(id, firstName, lastName, phoneNumber)
        {
            BadgeNumber = badgeNumber;
            Rank = new Rank(rank.Id, rank.Name);
            Specializations.AddRange(specializations.Select(spec => new Specialization(spec.Id, spec.Name)));
            Trainings.AddRange(trainings.Select(training => new Training(training.Id, training.Name)));
            WorkTime.AddRange(workTime.Select(time => new EmployeePeriod(time.Id, time.WorkerId, time.Start, time.End)));
            TimeOff = new EmployeePeriod(timeOff.Id, timeOff.WorkerId, timeOff.Start, timeOff.End);
        }
    }
}
