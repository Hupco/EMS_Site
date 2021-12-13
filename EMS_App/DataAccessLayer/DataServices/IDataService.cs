using System;
using System.Collections.Generic;
using DataAccessLayer.Entities;

namespace DataAccessLayer.DataServices
{
    public interface IDataService
    {
        Employee GetEmployeeById(Guid userId);
    }
}