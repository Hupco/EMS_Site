using System.Collections.Generic;
using System.Linq;
using System.Windows;
using LogicLayer;
using LogicLayer.Models;
using UserInterfaceLayer.Models;

namespace UserInterfaceLayer.Library.ModelsConverters
{
    public class ModelsConverter : IModelsConverter
    {
        public EmployeeCardViewModel ToEmployeeCardViewModel(Employee employee)
        {
            var employeeCardViewModel = new EmployeeCardViewModel();

            employeeCardViewModel.Id = employee.Id;
            employeeCardViewModel.FirstName = employee.FirstName;
            employeeCardViewModel.LastName = employee.LastName;
            employeeCardViewModel.PhoneNumber = employee.PhoneNumber;
            employeeCardViewModel.BadgeNumber = employee.BadgeNumber;
            employeeCardViewModel.Rank = employee.Rank.Name;
            //employeeCardViewModel.Specializations.AddRange() //todo: end getting employee

            return employeeCardViewModel;
        }
    }
}