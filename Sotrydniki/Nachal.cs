using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sotrydniki
{
    internal class Nachal : Sotr
    {
        private float dob_dn = 2;
        private float dob_noch = 4;
        private float zar_pl;
        private float zar_pl2;
        public void Vivod_2(List<Nachal> sotr)
        {
            Zarplata_final(sotr);
        }
        private void Zarplata_final(List<Nachal> sotr)
        {
            zar_pl = (30000 * ((pererabotka_dn * (dob_dn / 100)) + (pererabotka_n * (dob_noch / 100)))) + zar_pl;
            zar_pl2 = (30000 * ((pererabotka_dn_2 * (dob_dn / 100)) + (pererabotka_n_2 * (dob_noch / 100)))) + zar_pl2;
            zar_pl = zar_pl + 30000;
            zar_pl2 = zar_pl2 + 30000;
            Console.WriteLine($"Зарплата начальника 1 отдела: {zar_pl}");
            Console.WriteLine($"Зарплата начальника 2 отдела: {zar_pl2}");
        }
    }
}