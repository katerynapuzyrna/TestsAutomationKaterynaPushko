using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsAutomationKaterynaPushko.University
{
    internal class Student : Person 
    {
        public int year;
        public string specialization;
        public Student(string firstName, string lastName, string specialization, int year = 1) : base(firstName, lastName)
        {
            this.year = year;
            this.specialization = specialization;
        }
        public void RequestForLectorGroup(Lector lector)
        {
            lector.addCandidate(this);
        }
    }
}
