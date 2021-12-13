using LogicLayer.Models;
using System;
using System.Collections.Generic;

namespace LogicLayer.LogicServices
{
    public interface ILogicService
    {
        Employee GetEmployeeById(Guid guid);
    }
}