using System;

namespace UserInterfaceLayer.Models.Employee
{
    public class PeriodViewModel
    {
        public Guid Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}