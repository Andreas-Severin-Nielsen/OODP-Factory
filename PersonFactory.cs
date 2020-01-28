using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Factory
{
    abstract class PersonFactory
    {
        protected string GetUniqueID()
        {
            return DateTime.Now.Ticks.ToString();
        }

        public abstract IPerson CreatePerson(string name);
    }
}
