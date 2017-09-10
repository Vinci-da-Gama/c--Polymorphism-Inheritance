using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lpi.Classes
{
    public abstract class People
    {
        private string Name { get; set; }
        public void GetName(string n)
        {
            Name = n;
        }
    }

    public class Customer: People
    {
        public int CustomerId { get; set; }
    }

    public class Supplier: People
    {
        public int SupplierId { get; set; }
    }
}
