using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContainerManagementSystem
{
    public class UserModel
    {
        int id;
        string name;
        string address;
        string contact;
        string email;
        string username;
        string password;
        int role;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Role { get => role; set => role = value; }
    }
}