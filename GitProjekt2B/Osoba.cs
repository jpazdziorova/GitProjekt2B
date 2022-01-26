using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProjekt2B
{
    class Osoba
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get;set; }
        public DateTime DatumNarozeni { get; set; }


        public int GetVek()
        {
            return (int)(DateTime.Now - DatumNarozeni).TotalDays / 365;
        }
    }
}
