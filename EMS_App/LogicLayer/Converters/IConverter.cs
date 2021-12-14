using LogicLayer.Models;
using System.Collections.Generic;

namespace LogicLayer.Converters
{
    public interface IConverter
    {
        Employee ToLlEmployee(
            DataAccessLayer.Entities.Employee dalEmployee,
            DataAccessLayer.Entities.Rank dalRank,
            List<DataAccessLayer.Entities.Specialization> dalSpecializations,
            List<DataAccessLayer.Entities.Training> dalTrainings);
        EmployeePeriod ToLlEmployeePeriod(DataAccessLayer.Entities.EmployeePeriod dalPeriod);
        Rank ToLlRank(DataAccessLayer.Entities.Rank dalRank);
        Specialization ToLlSpecialization(DataAccessLayer.Entities.Specialization dalSpecialization);
        Training ToLlTraining(DataAccessLayer.Entities.Training dalTraining);
        DataAccessLayer.Entities.Employee ToDalEmployee(Employee newEmployee);
    }
}