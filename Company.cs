using System;
using System.Linq;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {
        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees { get; set; }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
        public Company(string companyName, DateTime companyCreated)
        {
            Name = companyName;
            CreatedOn = companyCreated;
        }

        public void ListEmployees()
        {
            foreach (var employee in Employees)
            {
                Console.WriteLine(
                    $"{employee.FirstName} {employee.LastName} works for {Name} as {employee.JobTitle} since {employee.HiringDate.ToString("MM/dd/yyyy")}"
                );
            }
        }
    }
}
