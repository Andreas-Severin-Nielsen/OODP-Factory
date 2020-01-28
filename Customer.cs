using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Factory
{
    class Customer : IPerson
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public float Balance { get; set; }

        public override string ToString()
        {
            return ID + " | " + Name + " | " + Balance.ToString();
        }
    }
}
