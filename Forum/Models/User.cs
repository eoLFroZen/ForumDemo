using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class User
    {

        public User(int id, string username, string firstName, string lastName)
        {
            Id = id;
            Username = username;
            FirstName = firstName;
            LastName = lastName;
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
