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

        public Worker GetWorkerById(Guid userId)
        {
            var worker = _dataContext.Workers?
                .SingleOrDefault(x => x.Id == userId);

            return worker;
        }

        public void AddWorker(Worker dalWorker)
        {
            _dataContext.Workers.Add(dalWorker);
            _dataContext.SaveChanges();
        }
    }
}
