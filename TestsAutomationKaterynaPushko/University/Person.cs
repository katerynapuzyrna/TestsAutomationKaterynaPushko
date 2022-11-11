using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsAutomationKaterynaPushko.University
{
    class Person
    {
        private string firstName = "Ivan";
        private string lastName = "Ivanov";
        private int age = 18;

        public string FirstName
        {
            get => firstName;
            set
            {
                if (value.Length <= 2)
                    throw new Exception("First Name can't be less than 3 characters length");
                else
                    firstName = value;
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                if (value.Length <= 2)
                    throw new Exception("Last name can't be less than 3 characters length");
                else
                    lastName = value;
            }
        }
        public int Age
        {
            get => age;
            set
            {
                if (value > 120)
                    throw new Exception("Incorrect age entered");
                else
                    age = value;
            }
        }
        public Person() { }
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Introduce()
        {
            if (age == 1) Console.WriteLine($"Hi! My name is {FirstName} {LastName}. I'm 1 year old.");
            else
                Console.WriteLine($"Hi! My name is {FirstName} {LastName}. I'm {Age} years old.");
        }
    }
}