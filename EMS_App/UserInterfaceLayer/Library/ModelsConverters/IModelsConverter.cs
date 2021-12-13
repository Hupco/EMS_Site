using LogicLayer.Models;
using System.Collections.Generic;
using UserInterfaceLayer.Models;

namespace UserInterfaceLayer.Library.ModelsConverters
{
    public interface IModelsConverter
    {
        EmployeeCardViewModel ToEmployeeCardViewModel(Employee employee);
    }
}