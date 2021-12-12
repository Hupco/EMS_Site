using System;

namespace LogicLayer.Models
{
    public class Client: Person
    {
        public string AdditionalInformation { get; set; }

        public Client(Guid id, string firstName, string lastName, int phoneNumber)
            : base(id, firstName, lastName, phoneNumber)
        {
        }
    }
}
