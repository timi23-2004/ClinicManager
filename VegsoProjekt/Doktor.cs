using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegsoProjekt
{
    internal class Doktor:Szemely
    {
        public string Szakterulet { get; set; }
        private static int AzonositoSzam = 4000;
        public Doktor()
        {

        }
        public Doktor(string szakterulet)
        {
            Szakterulet = szakterulet;
            AzonositoSzam++;
        }

        public string GetDoktorAdatai()
        {
            return $"{GetNev()} -AzonositoSzama:{AzonositoSzam} - Szakterulet: {Szakterulet}";
        }
    }
}
