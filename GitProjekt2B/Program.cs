using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProjekt2B
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();
            osoba.Jmeno = "Zdeněk";
            osoba.Prijmeni = "Jendřejčík";
            osoba.DatumNarozeni = DateTime.Parse("26.01.2003");

            Console.WriteLine(osoba.GetVek());

            Auto auto = new Auto();
            auto.Majitel = osoba;
            auto.SPZ = "5AA1215";
            auto.Znacka = "Audi";

            Console.ReadKey();
        }
    }
}
