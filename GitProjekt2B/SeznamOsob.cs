using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProjekt2B
{
    class SeznamOsob
    {
        public static List<Osoba> osoby = new List<Osoba>();

        public static void PridejOsoba(Osoba osoba)
        {
            osoby.Add(osoba);
        }

        public static Osoba VyhledejOsoba(string prijmeni)
        {
            return osoby.Find(x => x.Prijmeni == prijmeni);
        }
    }
}
