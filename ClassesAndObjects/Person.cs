using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Person //can have public, private, internal, most common is private
    {
        // Public properties usually capitalized
        public string FirstName { get; set; } //Getters and setters used to get and set this property// aka read and write
        public string LastName { get; set; }
        public int Age { get; set; }

        // Private properties called Fields and have an _ before
        private double _salary { get; set; }


        // These are methods used to interact with the private _salary
        public void setSalary(double salary)
        {
            _salary = salary;
        }
        public double getSalary()
        {
            return _salary;
        }

        public string getFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public string getFullName(string middleName)
        {
            return $"{FirstName} {middleName} {LastName}";
        }
    }
}
