using DataAccessLayer.DataServices;
using LogicLayer.Converters;
using LogicLayer.Models;
using System;

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

            var employee = _converter.ToLLEmployee(dalEmployee);

            return employee;
        }
    }
}
