﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserInterfaceLayer.Models.Employee
{
    public class EmployeePeriodViewModel: PeriodViewModel
    {
        public Guid WorkerId { get; set; }
    }
}