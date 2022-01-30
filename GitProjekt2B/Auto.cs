using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProjekt2B
{
    class Auto
    {
        public string Znacka { get; set; }
        public Osoba Majitel { get; set; }
        public string SPZ { get; set; }

        public override string ToString()
        {
            return String.Format($"{Znacka}, {SPZ}, {Majitel.Prijmeni},{Majitel.Jmeno}");
        }

    }
}
