using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework6_ITCompany
{
    class Program
    {
        public static string AskWhatEmloyeesAreDoing(Employee employee)
        {
            string employeeStatus = $"{employee.FirstName} {employee.LastName} {employee.Responsibility}";
            return employeeStatus;
        }

        static void Main(string[] args)
        {
            //initial list of persons who has responded for vacancies and send CV (have list of skills) - candidates for hiring
            List<Person> jobApplicants = new List<Person>();
            jobApplicants.Add(new Person("Alexander", "Ivanov", 31, 'M', new[] { "BE developer", "lead" }));
            jobApplicants.Add(new Person("Egor", "Levin", 18, 'M', new[] { "BE developer" }));
            jobApplicants.Add(new Person("Eva", "Johnson", 20, 'F', new[] { "FE developer" }));
            jobApplicants.Add(new Person("Mike", "Doe", 27, 'M', new[] { "DevOps" }));
            jobApplicants.Add(new Person("Polina", "Belova", 31, 'F', new[] { "QA engineer", "lead", "manual" }));
            jobApplicants.Add(new Person("John", "Wick", 57, 'M', new[] { "Security engineer" }));
            jobApplicants.Add(new Person("Jordan", "Belfort", 29, 'M', new[] { "BA" }));
            jobApplicants.Add(new Person("Petya", "NeTudaPopal", 5, 'M', Array.Empty<string>()));
            jobApplicants.Add(new Person("Vasya", "NeTudaPopal", 6, 'M', Array.Empty<string>()));
            jobApplicants.Add(new Person("John", "Snow", 27, 'M', Array.Empty<string>()));
            jobApplicants.Add(new Person("Maria", "Cury", 18, 'F', new[] { "QA engineer", "manual" }));
            jobApplicants.Add(new Person("Alexandra", "Krylova", 22, 'F', new[] { "QA engineer", "auto" }));
            jobApplicants.Add(new Person("Peter", "Rich", 19, 'M', new[] { "FE developer" }));
            jobApplicants.Add(new Person("Lev", "Pushkin", 28, 'M', new[] { "FE developer", "lead" }));
            jobApplicants.Add(new Person("Den", "Lock", 42, 'M', new[] { "PM" }));

            //displaying initial list of candidates - only name, age and gender
            Console.WriteLine("List of all persons who has responded for vacancies and send CV (have list of skills):");
            foreach (var person in jobApplicants)
            {
                Console.WriteLine(person);
            }

            var testITCompany = new Company();

            //hiring everyone who matches with the requirered skill(s) for positions and setting a random salary from predetermined ranges
            foreach (var person in jobApplicants)
            {
                testITCompany.TryHirePerson(person);
            }

            //displaying list of emploees (hired candidates)
            Console.WriteLine("\nList of persons who where hired");
            foreach (var employee in testITCompany.Employees)
            {
                Console.WriteLine(employee);
            }

            //Reporting status of employees
            Console.WriteLine("\nStatus:");
            foreach (var employee in testITCompany.Employees)
            {
                Console.WriteLine(AskWhatEmloyeesAreDoing(employee));
            }

            //Displaying list of QA employees with specialization
            Console.WriteLine("\nQA employees only list:");
            foreach (var employee in testITCompany.Employees)
            {
                if (employee is QAEmployee)
                {
                    Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.Role} {((QAEmployee)employee).Specialization}");
                }
            }

            //Displaying list of Dev employees with specialization
            Console.WriteLine("\nDev employees only list:");
            foreach (var employee in testITCompany.Employees)
            {
                if (employee is DevEmployee)
                {
                    Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.Role} {((DevEmployee)employee).Specialization}");
                }
            }
        }
    }
}
