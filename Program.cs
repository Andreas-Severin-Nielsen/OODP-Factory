using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonFactory personFactory = new CustomerFactory();

            IPerson kunde1 = personFactory.CreatePerson("Mike Rowe - Soft");

            Console.WriteLine(kunde1.ToString());
            Console.ReadKey();
        }
    }
}
