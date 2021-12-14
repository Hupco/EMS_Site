using System;

namespace UserInterfaceLayer.Models.Employee
{
    public class EmployeePeriodViewModel: PeriodViewModel
    {
        public Guid WorkerId { get; set; }
    }
}