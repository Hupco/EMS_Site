using System;

namespace LogicLayer.Models
{
    public class Person
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int PhoneNumber { get; private set; }

        public Person(Guid id, string firstName, string lastName, int phoneNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }
    }
}
