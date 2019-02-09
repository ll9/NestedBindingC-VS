using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedBinding.Models
{
    class Person
    {
        public string Name { get; set; }
        public int Alter { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}
