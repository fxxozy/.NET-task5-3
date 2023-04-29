using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    abstract class Engineer : IEmployee
    {
        protected string name;
        protected int WorkExperience { get; set; }
        public double Salary { get; set; }
        public string Name { get => name; set => name = value; }

        public Engineer(string engineerName, int workExperience, double salary)
        {
            name = engineerName;
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
