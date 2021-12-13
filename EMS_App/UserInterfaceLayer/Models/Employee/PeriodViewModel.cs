using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserInterfaceLayer.Models
{
    public class PeriodViewModel
    {
        public Guid Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}