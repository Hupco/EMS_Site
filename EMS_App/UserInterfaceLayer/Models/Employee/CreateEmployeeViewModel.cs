using System;

namespace UserInterfaceLayer.Models.Employee
{
    public class CreateEmployeeViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
    }
}