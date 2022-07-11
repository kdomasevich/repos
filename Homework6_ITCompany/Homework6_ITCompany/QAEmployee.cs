using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_ITCompany
{
    public class QAEmployee : Employee
    {
        public QAEmployee(Employee employee, string specialization) : base(employee.Person, employee.Role, employee.Rate, employee.Responsibility )
        {
            this.Specialization = specialization;
        }
        public string Specialization { get; set; }
    }
}
