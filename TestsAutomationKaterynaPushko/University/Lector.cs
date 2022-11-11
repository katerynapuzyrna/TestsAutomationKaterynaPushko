using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsAutomationKaterynaPushko.University
{
    internal class Lector : Person
    {
        public string specialization;
        public List<Student> groupOfCandidates = new();
        public List<Student> groupOfMembers = new();

        public Lector(string firstName, string lastName, string specialization) : base(firstName, lastName)
        {
            this.specialization = specialization;
        }

        public void addCandidates(List<Student> students) 
        {
            foreach (Student i in students) 
            {
                if (i.specialization == specialization)
                    groupOfCandidates.Add(i);
                else Console.WriteLine($"Can't add {i.FirstName} {i.LastName} with specialization {i.specialization} to the group of the lector {FirstName} {LastName} with specialization {specialization}.");
            }
            addMembers(groupOfCandidates);
        }
        public void addCandidate(Student student)
        {
            groupOfCandidates.Add(student);
            addMembers(groupOfCandidates);
        }

        public void addMembers(List<Student> groupOfCandidates)
        {
            if (groupOfCandidates.Count >= 5 || groupOfMembers.Count >= 5) 
            {
                foreach (Student i in groupOfCandidates)
                {
                    groupOfMembers.Add(i);
                }
                groupOfCandidates.Clear();
            }
        }

        public void showCandidatesList()
        {
            if (groupOfCandidates.Count != 0)
            {
                Console.WriteLine($"Candidates to the group of {FirstName} {LastName} lector:");

                foreach (Student i in groupOfCandidates)
                {
                    Console.WriteLine($"{i.FirstName} {i.LastName}");
                }
            }
            else Console.WriteLine($"{FirstName} {LastName} lector doesn't have candidates to the group.");
        }

        public void showMembersList()
        {
            if (groupOfMembers.Count != 0)
            {
                Console.WriteLine($"Members of the {FirstName} {LastName} lector group:");

            foreach (Student i in groupOfMembers)
            {
                Console.WriteLine($"{i.FirstName} {i.LastName}");
            }
            }
            else Console.WriteLine($"{FirstName} {LastName} lector doesn't have members in the group.");
        }
    }
}
