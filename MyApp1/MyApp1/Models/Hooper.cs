using System;
using System.Collections.Generic;
using System.Text;
using MyApp1.Interfaces;

namespace MyApp1.Models
{
    class Hooper: IPerson
    {
        public string FirstName { get => _firstName; set => _firstName = value;}
        private string LastName { get => _lastName; set => _lastName = value; }

        public string Gender;
        public string UserName;
        public string Email;
        public string Password;
        public string DateOfBirth;

        private string _firstName;
        private string _lastName;

        public bool Login()
        {
            if (LastName != string.Empty)
            {
                return true;
            }
            else return false;
        }
    }
}
