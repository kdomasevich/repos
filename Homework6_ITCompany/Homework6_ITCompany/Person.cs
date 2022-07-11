using System;

namespace Homework6_ITCompany
{
    public class Person
    {
        public Person(string fName, string lName, int age, char gender, string[] skills)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Age = age;
            this.Gender = gender;
            this.Skills = skills;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Age} {Gender}";
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public char Gender { get; set; }

        public string[] Skills { get; set; }
    }
}