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
            DataAccessLayer.Entities.Rank dalEmployeeRank = _dataService.GetRankById(dalEmployee.Rank);
            List<DataAccessLayer.Entities.Specialization> dalEmployeeSpecializations = _dataService.GetSpecializationsByIds(dalEmployee.Specializations);
            List<DataAccessLayer.Entities.Training> dalEmployeeTrainings = _dataService.GetTrainingsByIds(dalEmployee.Trainings);

            var employee = _converter.ToLLEmployee(dalEmployee, dalEmployeeRank, dalEmployeeSpecializations, dalEmployeeTrainings);

            return employee;
        }
    }
}
