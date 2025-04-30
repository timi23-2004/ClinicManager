using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegsoProjekt
{
    internal class Szolgaltatas
    {
        public string szolgalatasNev { get; set; }
        public double szolgalatasAra { get; set; }
        public string szaknev { get; set; }

        public Szolgaltatas()
        {

        }
        public Szolgaltatas(string szolgalatasNev, double szolgalatasAra, string szaknev)
        {
            this.szolgalatasNev = szolgalatasNev;
            this.szolgalatasAra = szolgalatasAra;
            this.szaknev = szaknev;
        }
        public override string ToString()
        {
            return $"{szolgalatasNev},{szolgalatasAra}";
        }
    }
}
