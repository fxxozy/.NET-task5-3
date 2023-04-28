using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Engineer engineer1 = new Worker("Bob", 5, 40000);
            Engineer engineer2 = new Worker("Tom", 3, 30000);
            Engineer engineer3 = new Worker("Max", 7, 50000);
            Director director1 = new Director("Andrey", 10, 100000, "firstCompany");
            Director director2 = new Director("Max", 20, 100000, "secondCompany");

            director1.addWard(director2);
            director1.addWard(engineer1);
            director1.addWard(engineer2);
            director1.addWard(engineer3);
            director1.raiseSalary(engineer1);

            director1.printWards();
        }
    }
}
