using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Factory
{
    class CustomerFactory : PersonFactory
    {

        public override IPerson CreatePerson(string name)
        {
            Customer customer = new Customer();
            customer.Name = name;
            customer.ID = "C-" + GetUniqueID();
            customer.Balance = 0.0f;
            return customer;
        }
    }
}
