using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12122022_Filip_test
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }


        public Employee(string firstName, string lastName, string phone, string email, DateTime birthdate)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            Birthdate = birthdate;
        }

    }

}
