using System.Data.Entity;
using DataAccessLayer.Entities;

namespace DataAccessLayer
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<EmployeePeriod> Periods { get; set; }
    }
}
