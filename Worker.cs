using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Worker : Engineer
    {

        public Worker(string name, int workExperince, double salary) : base(name, workExperince, salary) {}

        public override void leaveJob()
        {
            Console.WriteLine("Worker has left job");
        }

        public override void workOnProject()
        {
            Console.WriteLine("Worker is engaged in a project");
        }

        public override string ToString()
        {
            return $"[name: {Name}, workExperience: {WorkExperience}, salary: {Salary}]\n";
        }
    }
}
