using LogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicLayer.Converters
{
    public class Converter : IConverter
    {
        public Employee ToLLEmployee(
            DataAccessLayer.Entities.Employee dalEmployee,
            DataAccessLayer.Entities.Rank dalRank,
            List<DataAccessLayer.Entities.Specialization> dalSpecializations,
            List<DataAccessLayer.Entities.Training> dalTrainings)
        {
            Rank rank = ToLLRank(dalRank);

            List<Specialization> specializations = new List<Specialization>();
            specializations.AddRange(dalSpecializations.Select(dalSpec => ToLLSpecialization(dalSpec)));

            List<Training> trainings = new List<Training>();
            trainings.AddRange(dalTrainings.Select(dalTraining => ToLLTraining(dalTraining)));

            List<EmployeePeriod> workTime = new List<EmployeePeriod>();
            workTime.AddRange(dalEmployee.WorkTimes.Select(dalPeriod => ToLLEmployeePeriod(dalPeriod)));

            var timeOff = ToLLEmployeePeriod(dalEmployee.TimeOff);

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

        public EmployeePeriod ToLLEmployeePeriod(DataAccessLayer.Entities.EmployeePeriod dalPeriod)
        {
            return new EmployeePeriod(dalPeriod.Id, dalPeriod.WorkerId, dalPeriod.Start, dalPeriod.End);
        }

        public Training ToLLTraining(DataAccessLayer.Entities.Training dalTraining)
        {
            return new Training(dalTraining.Id, dalTraining.Name);
        }

        public Specialization ToLLSpecialization(DataAccessLayer.Entities.Specialization dalSpecialization)
        {
            return new Specialization(dalSpecialization.Id, dalSpecialization.Name);
        }

        public Rank ToLLRank(DataAccessLayer.Entities.Rank dalRank)
        {
            return new Rank(dalRank.Id, dalRank.Name);
        }

    }
}
