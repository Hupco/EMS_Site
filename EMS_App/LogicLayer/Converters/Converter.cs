using LogicLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace LogicLayer.Converters
{
    public class Converter : IConverter
    {
        public Employee ToLlEmployee(
            DataAccessLayer.Entities.Employee dalEmployee,
            DataAccessLayer.Entities.Rank dalRank,
            List<DataAccessLayer.Entities.Specialization> dalSpecializations,
            List<DataAccessLayer.Entities.Training> dalTrainings)
        {
            var rank = ToLlRank(dalRank);

            var specializations = new List<Specialization>();
            specializations.AddRange(dalSpecializations.Select(dalSpec => ToLlSpecialization(dalSpec)));

            var trainings = new List<Training>();
            trainings.AddRange(dalTrainings.Select(dalTraining => ToLlTraining(dalTraining)));

            var workTime = new List<EmployeePeriod>();
            workTime.AddRange(dalEmployee.WorkTimes.Select(dalPeriod => ToLlEmployeePeriod(dalPeriod)));

            var timeOff = ToLlEmployeePeriod(dalEmployee.TimeOff);

            var employee = new Employee(
                dalEmployee.Id,
                dalEmployee.FirstName,
                dalEmployee.LastName,
                dalEmployee.PhoneNumber,
                dalEmployee.BadgeNumber,
                rank,
                specializations,
                trainings,
                workTime,
                timeOff
                );

            return employee;
        }

        public EmployeePeriod ToLlEmployeePeriod(DataAccessLayer.Entities.EmployeePeriod dalPeriod)
        {
            return new EmployeePeriod(dalPeriod.Id, dalPeriod.WorkerId, dalPeriod.Start, dalPeriod.End);
        }

        public Training ToLlTraining(DataAccessLayer.Entities.Training dalTraining)
        {
            return new Training(dalTraining.Id, dalTraining.Name);
        }

        public DataAccessLayer.Entities.Employee ToDalEmployee(Employee newEmployee)
        {
            throw new System.NotImplementedException();
        }

        public Specialization ToLlSpecialization(DataAccessLayer.Entities.Specialization dalSpecialization)
        {
            return new Specialization(dalSpecialization.Id, dalSpecialization.Name);
        }

        public Rank ToLlRank(DataAccessLayer.Entities.Rank dalRank)
        {
            return new Rank(dalRank.Id, dalRank.Name);
        }

    }
}
