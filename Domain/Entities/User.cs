using Shared.Entities;
using System;

namespace Domain.Entities
{
    public class User : Entity
    {
        public User(string username, string password)
        {
            Username = username;
            Password = password;
            isActive = false;
        }

        public string Username { get; private set; }
        public string Password { get; private set; }
        public bool isActive { get; private set; }
        public void Activate() => isActive = true;
        public void Deactivate() => isActive = false;


    }
}
