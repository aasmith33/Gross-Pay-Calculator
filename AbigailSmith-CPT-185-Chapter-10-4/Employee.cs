using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbigailSmith_CPT_185_Chapter_10_4
{
    class Employee
    {
        public Employee()
        {
            Name = "";
            Number = 0;
            Pay = 0;
        }
        public string Name { get; set; }
        public int Number { get; set; }
        public decimal Pay { get; set; }
    }
}
