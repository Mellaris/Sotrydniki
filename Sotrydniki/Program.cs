using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sotrydniki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Nachal> sotr = new List<Nachal>(10);
            Nachal nachal = new Nachal();
            nachal.Sozdan(sotr);
            nachal.Vivod(sotr);
            nachal.Vivod_2(sotr);
            Console.ReadKey();
        }
    }
}
