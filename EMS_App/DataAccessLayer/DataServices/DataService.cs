using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.Entities;

namespace DataAccessLayer.DataServices
{
    public class DataService : IDataService
    {
        private readonly DataContext _dataContext;

        public DataService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Employee GetEmployeeById(Guid userId)
        {
            var worker = _dataContext.Employees?
                .SingleOrDefault(x => x.Id == userId);

            return worker;
        }

        public void AddEmployee(Employee dalEmployee)
        {
            _dataContext.Employees.Add(dalEmployee);
            _dataContext.SaveChanges();
        }
    }
}
