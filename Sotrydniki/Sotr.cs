using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sotrydniki
{
    internal class Sotr : Info
    {
        protected int dnevn_sm;
        protected int dnevn_sm_2;
        protected int nochn_sm = 0;
        protected int nochn_sm_2 = 0;
        protected int zar;
        private int b_dnsm = 15;
        protected int b_nsm = 5;
        protected int pererabotka_dn;
        protected int pererabotka_dn_2;
        protected int pererabotka_n;
        protected int pererabotka_n_2;
        public void Vivod(List<Nachal> sotr)
        {
            Zarplata(sotr);
        }
        protected virtual void Zarplata(List<Nachal> sotr)
        {
            Random rd = new Random();
            foreach (Nachal poisk in sotr)
            {
                if (poisk.description == 1)
                {                   
                    dnevn_sm = rd.Next(1, 30);
                    Console.WriteLine(dnevn_sm);
                    if (dnevn_sm > b_dnsm)
                    {
                        pererabotka_dn = (dnevn_sm - b_dnsm) + pererabotka_dn;
                    }
                    if (poisk.age >= 18)
                    {
                        nochn_sm = 30 - dnevn_sm;
                        if (nochn_sm > b_nsm)
                        {
                            pererabotka_n = (nochn_sm - b_nsm) + pererabotka_n;
                        }
                    }
                    Zarplata_2(dnevn_sm, nochn_sm);
                    nochn_sm = 0;
                    Console.WriteLine($"Имя сотрудника: {poisk.name}");
                    Console.WriteLine($"Зарплата: {zar}");
                }
            }
            foreach (Nachal poisk in sotr)
            {
                if (poisk.description == 2)
                {
                    dnevn_sm_2 = rd.Next(1, 30);
                    Console.WriteLine(dnevn_sm_2);
                    if (dnevn_sm_2 > b_dnsm)
                    {
                        pererabotka_dn_2 = (dnevn_sm_2 - b_dnsm) + pererabotka_dn_2;
                    }
                    if (poisk.age >= 18)
                    {
                        nochn_sm_2 = 30 - dnevn_sm_2;
                        if (nochn_sm_2 > b_nsm)
                        {
                            pererabotka_n_2 = (nochn_sm_2 - b_nsm) + pererabotka_n_2;
                        }
                    }
                    Zarplata_2(dnevn_sm_2, nochn_sm_2);
                    nochn_sm_2 = 0;
                    Console.WriteLine($"Имя сотрудника: {poisk.name}");
                    Console.WriteLine($"Зарплата: {zar}");
                }
            }
        }
        protected void Zarplata_2(int a, int b)
        {           
            zar = 0;
            zar = a * 1300 + b * 1500;
        }
    }
}