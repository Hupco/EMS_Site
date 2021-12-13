using System;
using System.Collections.Generic;

namespace UserInterfaceLayer.Models
{
    public class EmployeeCardViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public int BadgeNumber { get; set; }
        public string Rank { get; set; }
        public List<string> Specializations { get; set; }
        public List<string> Trainings { get; set; }
        public List<EmployeePeriodViewModel> WorkTimes { get; set; }
        public EmployeePeriodViewModel TimeOff { get; set; }
    }
}