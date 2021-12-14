using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;
using DataAccessLayer.DataServices;
using LogicLayer.Models;

namespace LogicLayer.EmployeeModifier
{
    public class EmployeeModifier : IEmployeeModifier
    {
        private readonly IDataService _dataService;

        public EmployeeModifier(IDataService dataService)
        {
            _dataService = dataService;
        }

        public void CompleteNewEmployee(ref Employee newEmployee)
        {
            var occupiedBadgeNumbers = _dataService.GetOccupiedBadgeNumbers(); //todo: check
            var internsBadges = occupiedBadgeNumbers
                .Where(number => number / 100 >= 1).ToList(); // divide by 100 because interns numbers starts from 100;
            //todo finish choosing first free intern number
        }
    }
}
