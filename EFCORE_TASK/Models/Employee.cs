using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_TASK.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }

        public float Salary { get; set; }

        public string PhotoPath { get; set; }
    }
}
