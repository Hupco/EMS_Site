using LogicLayer.Models;
using System.Collections.Generic;

namespace LogicLayer.Converters
{
    public interface IConverter
    {
        Employee ToLLEmployee(
            DataAccessLayer.Entities.Employee dalEmployee,
            DataAccessLayer.Entities.Rank dalRank,
            List<DataAccessLayer.Entities.Specialization> dalSpecializations,
            List<DataAccessLayer.Entities.Training> dalTrainings);
        EmployeePeriod ToLLEmployeePeriod(DataAccessLayer.Entities.EmployeePeriod dalPeriod);
        Rank ToLLRank(DataAccessLayer.Entities.Rank dalRank);
        Specialization ToLLSpecialization(DataAccessLayer.Entities.Specialization dalSpecialization);
        Training ToLLTraining(DataAccessLayer.Entities.Training dalTraining);
    }
}