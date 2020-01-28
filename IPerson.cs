using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Factory
{
    interface IPerson
    {
        string ID { get; set; }
        string Name { get; set; }
        string ToString();
    }
}
