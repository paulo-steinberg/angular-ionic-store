using Shared.Entities;
using System;

namespace Domain.Entities
{
    public class Customer : Entity
    {
        public Customer(string firstName, string lastName, DateTime birthDay, string email, User user)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            Email = email;
            User = user;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDay { get; private set; }
        public string Email { get; private set; }
        public User User { get; private set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
