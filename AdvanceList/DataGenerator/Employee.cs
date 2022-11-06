using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceList.DataGenerator
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Email { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public int Id { get; set; }
        public int City { get; set; }
        public string Street { get; set; }
    }
}

