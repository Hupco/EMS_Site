

namespace LogicLayer.Converters
{
    public interface IConverter
    {
        Models.Employee ToLLEmployee(DataAccessLayer.Entities.Employee dalEmployee);
    }
}