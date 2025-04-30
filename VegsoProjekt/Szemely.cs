using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegsoProjekt
{
    internal class Szemely
    {
        public string Cnp { get; set; }
        public string Nev { get; set; }
        public string TelefonSzam { get; set; }
        public Szemely()
        {

        }
        public Szemely(string Cnp, string Nev, string TelefonSzam)
        {
            this.Cnp = Cnp;
            this.Nev = Nev;
            this.TelefonSzam = TelefonSzam;
        }
        public string GetNev()
        {
            return Nev;
        }
    }
}
