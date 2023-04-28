using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Director : Engineer
    {
        public string CompanyName { get; set; }
        public List<Engineer> wards = new();

        public Director(string name, int workExperince, double salary, string companyName) : base(name, workExperince, salary)
        {
            this.CompanyName = companyName;
        }

        public override void workOnProject()
        {
            Console.WriteLine("Director with wards are working on project!");
        }

        public override void leaveJob()
        {
            Console.WriteLine("Director has left job!");
        }

        public void raiseSalary(Engineer engineer)
        {
            try
            {
                Worker worker = (Worker)engineer;
                if (wards.Contains(engineer))
                {
                    engineer.Salary *= 1.2;
                }
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("You can't raise a salary of another director!");
            }
        }

        public void addWard(Engineer engineer)
        {
            try
            {
                Worker worker = (Worker)engineer;
                wards.Add(engineer);                
            } catch (InvalidCastException e)
            {
                Console.WriteLine("You can't add a director to the list of wards!");
            }
 
        }

        public void printWards()
        {
            Console.WriteLine("Wards: ");
            foreach(Worker worker in wards) 
            {
                Console.Write(worker.ToString());
            }
        }

        public override string ToString() => $"[name: {Name}, workExperience: {WorkExperience}, salary: {Salary}, companyName: {CompanyName}]\n";
        
    }
}
