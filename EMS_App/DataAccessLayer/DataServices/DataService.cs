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

        public void CreateEmployee(Employee dalEmployee)
        {
            _dataContext.Employees.Add(dalEmployee);
            _dataContext.SaveChanges();
        }

        public Rank GetRankById(int rankId)
        {
            var rank = _dataContext.Ranks.SingleOrDefault(x => x.Id == rankId);

            return rank;
        }

        public List<Specialization> GetSpecializationsByIds(List<int> specializationsIds)
        {
            var specializations = _dataContext.Specializations
                .Where(x => specializationsIds.Contains(x.Id))
                .ToList();

            return specializations;
        }

        public List<Training> GetTrainingsByIds(List<int> trainingsIds)
        {
            var trainings = _dataContext.Trainings
                .Where(x => trainingsIds.Contains(x.Id))
                .ToList();

            return trainings;
        }

        public List<EmployeePeriod> GetWorkTimeByEmployeeId(Guid id)
        {
            var workTime = _dataContext.Periods
                .Where(x => x.Id == id)
                .ToList();
            return workTime;
        }

        public List<int> GetOccupiedBadgeNumbers()
        {
            var badgeNumbers = _dataContext.Employees?
                .Select(employee => employee.BadgeNumber)
                .ToList();

            return badgeNumbers;
        }
    }
}
