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

        public void TryHirePerson(Person person)
        {
            Random rand = new Random();

            if (person.Skills.Contains( "BE developer"))
            {
                var rate = rand.Next(BEMinSalary, BEMaxSalary);
                if (person.Skills.Contains("lead"))
                {
                    var devEmployee = new DevEmployee(person, "BE", rate, "leading BE developers", "lead");
                    this.Employees.Add(devEmployee);
                }
                else
                {
                    var devEmployee = new DevEmployee(person, "BE", rate, "writing code for BE", "specialization is not defined yet");
                    this.Employees.Add(devEmployee);
                }
            }
            else if (person.Skills.Contains( "FE developer"))
            {
                var rate = rand.Next(FEMinSalary, FEMaxSalary);
                if (person.Skills.Contains("lead"))
                {
                    var devEmployee = new DevEmployee(person, "FE", rate, "leading FE developers", "lead");
                    this.Employees.Add(devEmployee);
                }
                else
                {
                    var devEmployee = new DevEmployee(person, "FE", rate, "writing code for FE", "specialization is not defined yet");
                    this.Employees.Add(devEmployee);
                }
            }
            else if (person.Skills.Contains("DevOps"))
            {
                var rate = rand.Next(DevOpsMinSalary, DevOpsMaxSalary);
                var employee = new Employee(person,"DevOps", rate, "writing code for infrastructure");
                this.Employees.Add(employee);
            }
            else if (person.Skills.Contains("QA engineer"))
            {
                var rate = rand.Next(QAMinSalary, QAMaxSalary);
                if (person.Skills.Contains("lead"))
                {
                    var qaEmployee = new QAEmployee(person, "QA", rate, "leading manual and/or auto QAs", "lead");
                    this.Employees.Add(qaEmployee);
                }
                else if (person.Skills.Contains("manual"))
                {
                    var qaEmployee = new QAEmployee(person, "QA", rate, "testing", "manual");
                    this.Employees.Add(qaEmployee);
                }
                else if (person.Skills.Contains("auto"))
                {
                    var qaEmployee = new QAEmployee(person, "QA", rate, "testing", "auto");
                    this.Employees.Add(qaEmployee);
                }
            }
            else if (person.Skills.Contains("Security engineer"))
            {
                var rate = rand.Next(SecurityMinSalary, SecurityMaxSalary);
                var employee = new Employee(person, "Security", rate, "performing security audits, testing");
                this.Employees.Add(employee);
            }
            else if (person.Skills.Contains("BA"))
            {
                var rate = rand.Next(BAMinSalary, BAMaxSalary);
                var employee = new Employee(person, "BA", rate, "writing business documentation, communicating with customer");
                this.Employees.Add(employee);
            }
            else if (person.Skills.Contains("PM"))
            {
                var rate = rand.Next(PMMinSalary, PMMaxSalary);
                var employee = new Employee(person, "PM", rate, "team managing");
                this.Employees.Add(employee);
            }
        }
    }
}
