using System.Linq;
using LogicLayer.Models;
using UserInterfaceLayer.Models.Employee;

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
            employeeCardViewModel.Specializations.AddRange(employee.Specializations.Select(spec => spec.Name));
            employeeCardViewModel.Trainings.AddRange(employee.Trainings.Select(traininig => traininig.Name));
            employeeCardViewModel.WorkTime.AddRange(employee.WorkTime.Select(time => new EmployeePeriodViewModel()
            {
                Id = time.Id,
                WorkerId = time.WorkerId,
                Start = time.Start,
                End = time.End
            }));
            employeeCardViewModel.TimeOff = new EmployeePeriodViewModel()
            {
                Id = employee.TimeOff.Id,
                WorkerId = employee.TimeOff.WorkerId,
                Start = employee.TimeOff.Start,
                End = employee.TimeOff.End
            };

            return employeeCardViewModel;
        }

        public Employee ToNewEmployee(CreateEmployeeViewModel newEmployeeViewModel)
        {
            var newEmployee = new Employee(
                    newEmployeeViewModel.Id,
                    newEmployeeViewModel.FirstName,
                    newEmployeeViewModel.LastName,
                    newEmployeeViewModel.PhoneNumber);

            return newEmployee;
        }
    }
}