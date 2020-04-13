using System;
using System.Collections.Generic;
using System.Text;

namespace PluginBase
{
    public class User
    {
        private string name;
        private string surname;
        private string email;

        public User(){}

        public void setName(string name){this.name = name;}
        public void setSurname(string surname){this.surname = surname;}
        public void setEmail(string email){this.email = email;}

        public string getName() { return name; }
        public string getSurname() { return surname; }
        public string getEmail() { return email; }
    }
}
