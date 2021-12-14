using LogicLayer.Models;
using System;

namespace LogicLayer.LogicServices
{
    public interface ILogicService
    {
        Employee GetEmployeeById(Guid guid);
        void AddNewEmployee(Employee newEmployee);
    }
}