using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB_Context.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /*A collection of Employee that it contains*/
        public ICollection<Employee> Employee { get; set; }
       
    }
}