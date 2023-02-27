using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company company = new Company("Hedges Logistics", new DateTime(1992, 03, 06));
            company.Employees = new List<Employee>();

            // Create three employees
            Employee WillHedges = new Employee()
            {
                FirstName = "Will",
                LastName = "Hedges",
                JobTitle = "CEO",
                HiringDate = new DateTime(1992, 03, 06)
            };

            Employee JordanPlaxico = new Employee()
            {
                FirstName = "Jordan",
                LastName = "Plaxico",
                JobTitle = "Vice President",
                HiringDate = new DateTime(2017, 05, 13)
            };

            Employee SammyHedges = new Employee()
            {
                FirstName = "Sammy",
                LastName = "Hedges",
                JobTitle = "CFO",
                HiringDate = new DateTime(2019, 07, 11)
            };

            // Assign the employees to the company
            company.Employees.Add(WillHedges);
            company.Employees.Add(JordanPlaxico);
            company.Employees.Add(SammyHedges);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            company.ListEmployees();
        }
    }
}
