using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    interface IEmployee
    {
        public string Name { get; set; }

        public void workOnProject();
        public void leaveJob();
    }
}
