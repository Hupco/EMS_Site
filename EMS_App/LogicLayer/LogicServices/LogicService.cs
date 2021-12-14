using DataAccessLayer.DataServices;
using LogicLayer.Converters;
using LogicLayer.Models;
using System;
using System.Collections.Generic;

namespace LogicLayer.LogicServices
{
    public class LogicService : ILogicService
    {
        private readonly IDataService _dataService;
        private readonly IConverter _converter;

        public LogicService(IDataService dataService, IConverter converter)
        {
            _dataService = dataService;
            _converter = converter;
        }

        public Employee GetEmployeeById(Guid id)
        {
            var dalEmployee = _dataService.GetEmployeeById(id);
            var dalEmployeeRank = _dataService.GetRankById(dalEmployee.Rank);
            var dalEmployeeSpecializations = _dataService.GetSpecializationsByIds(dalEmployee.Specializations);
            var dalEmployeeTrainings = _dataService.GetTrainingsByIds(dalEmployee.Trainings);

            var employee = _converter.ToLlEmployee(dalEmployee, dalEmployeeRank, dalEmployeeSpecializations, dalEmployeeTrainings);

            return employee;
        }

        public void AddNewEmployee(Employee newEmployee)
        {

            var dalNewEmployee = _converter.ToDalEmployee(newEmployee);
        }
    }
}
