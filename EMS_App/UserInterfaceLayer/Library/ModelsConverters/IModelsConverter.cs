using LogicLayer.Models;
using UserInterfaceLayer.Models.Employee;

namespace UserInterfaceLayer.Library.ModelsConverters
{
    public interface IModelsConverter
    {
        EmployeeCardViewModel ToEmployeeCardViewModel(Employee employee);
    }
}