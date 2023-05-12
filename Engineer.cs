using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    abstract class Engineer : IEmployee
    {
        public int WorkExperience { get; set; }
        public double Salary { get; set; }
        public string Name { get; set; }

        public Engineer(string engineerName, int workExperience, double salary)
        {
            Name = engineerName;
            WorkExperience = workExperience;
            Salary = salary;
        }

        public abstract void workOnProject();
        public abstract void leaveJob();

        public double getAnnualSalary()
        {
            return this.Salary + WorkExperience * 5000;
        }
    }
}
