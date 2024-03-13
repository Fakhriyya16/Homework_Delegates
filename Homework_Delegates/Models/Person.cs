using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Delegates.Models
{
    internal class Person : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }
    }
}
