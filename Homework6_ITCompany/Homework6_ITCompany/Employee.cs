using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_ITCompany
{
    public class Employee : Person
    {
        public Employee(Person person, string role, decimal rate, string responsibility) : base(person.FirstName, person.LastName, person.Age, person.Gender, person.Skills)
        {
            this.Role = role;
            this.Rate = rate;
            this.Responsibility = responsibility;
        }

        public Company CurrentCompany { get; set; } //???

        public string Role { get; set; }

        public decimal Rate { get; set; }

        public string Responsibility { get; set; }

        public Person Person { get; internal set; } //???

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Role} {Rate:C}";
        }

       
    }
}
