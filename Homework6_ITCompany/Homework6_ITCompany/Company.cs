using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_ITCompany
{
    public class Company
    {
        //below is the salaries ranges depend on positions
        private const int BEMaxSalary = 4000;
        private const int BEMinSalary = 2000;
        private const int FEMaxSalary = 4000;
        private const int FEMinSalary = 2000;
        private const int QAMaxSalary = 4000;
        private const int QAMinSalary = 2000;
        private const int DevOpsMaxSalary = 5000;
        private const int DevOpsMinSalary = 3000;
        private const int SecurityMaxSalary = 8000;
        private const int SecurityMinSalary = 4000;
        private const int BAMaxSalary = 6000;
        private const int BAMinSalary = 500;
        private const int PMMaxSalary = 3000;
        private const int PMMinSalary = 2000;

        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<QAEmployee> QAEmployees { get; set; } = new List<QAEmployee>();

        public void TryHirePerson(Person person)
        {
            Random rand = new Random();

            if (person.Skills.Contains( "BE developer"))
            {
                var rate = rand.Next(BEMinSalary, BEMaxSalary);
                var employee = new Employee(person, "BE", rate, "writing code for BE");
                employee.CurrentCompany = this;
                this.Employees.Add(employee);
            }
            else if (person.Skills.Contains( "FE developer"))
            {
                var rate = rand.Next(FEMinSalary, FEMaxSalary);
                var employee = new Employee(person, "FE", rate, "writing code for FE");
                employee.CurrentCompany = this;
                this.Employees.Add(employee);
            }
            else if (person.Skills.Contains("DevOps"))
            {
                var rate = rand.Next(DevOpsMinSalary, DevOpsMaxSalary);
                var employee = new Employee(person,"DevOps", rate, "writing code for infrastructure");
                employee.CurrentCompany = this;
                this.Employees.Add(employee);
            }
            else if (person.Skills.Contains("QA engineer"))
            {
                var rate = rand.Next(QAMinSalary, QAMaxSalary);
                var employee = new Employee(person, "QA", rate, "testing");
                employee.CurrentCompany = this;
                this.Employees.Add(employee);
                /*if (person.Skills.Contains("manual"))
                {
                    var qaemployee = new QAEmployee(employee, "manual");
                    this.QAEmployees.Add(qaemployee);
                }
                if (person.Skills.Contains("auto"))
                {
                    var qaemployee = new QAEmployee(employee, "auto");
                    this.QAEmployees.Add(qaemployee);
                }*/
            }
            else if (person.Skills.Contains("Security engineer"))
            {
                var rate = rand.Next(SecurityMinSalary, SecurityMaxSalary);
                var employee = new Employee(person, "Security", rate, "performing security audits, testing");
                employee.CurrentCompany = this;
                this.Employees.Add(employee);
            }
            else if (person.Skills.Contains("BA"))
            {
                var rate = rand.Next(BAMinSalary, BAMaxSalary);
                var employee = new Employee(person, "BA", rate, "writing business documentation, communicating with customer");
                employee.CurrentCompany = this;
                this.Employees.Add(employee);
            }
            else if (person.Skills.Contains("PM"))
            {
                var rate = rand.Next(PMMinSalary, PMMaxSalary);
                var employee = new Employee(person, "PM", rate, "team managing");
                employee.CurrentCompany = this;
                this.Employees.Add(employee);
            }
        }
    }
}
