using System;
using System.Collections.Generic;
using DataAccessLayer.Entities;

namespace DataAccessLayer.DataServices
{
    public interface IDataService
    {
        Employee GetEmployeeById(Guid userId);
        Rank GetRankById(int rank);
        List<Specialization> GetSpecializationsByIds(List<int> specializations);
        List<Training> GetTrainingsByIds(List<int> trainings);
        List<EmployeePeriod> GetWorkTimeByEmployeeId(Guid id);
        List<int> GetOccupiedBadgeNumbers();
    }
}