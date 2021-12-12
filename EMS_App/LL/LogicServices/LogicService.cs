using DataAccessLayer.DataServices;
using LogicLayer.Converters;

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

    }
}
