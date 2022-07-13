using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_ITCompany
{
    public class DevEmployee : Employee
    {
        public DevEmployee(Person person, string role, decimal rate, string responsibility, string specialization) : base(person, role, rate, responsibility)
        {
            this.Specialization = specialization;
        }
        public string Specialization { get; set; }
    }
}
