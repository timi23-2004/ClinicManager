using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegsoProjekt
{
    internal class Szakrendeles
    {
        public string szakNev { get; set; }
        public List<Szolgaltatas> szolgalatasok { get; set; }
        public Szakrendeles() { }
        public Szakrendeles(string szakNev)
        {
            this.szakNev = szakNev;
            this.szolgalatasok = new List<Szolgaltatas>();
        }

        public void addSzolgalatas(Szolgaltatas szolgalatas)
        {
            szolgalatasok.Add(szolgalatas);
        }
        public List<string> getSzolgalatasListaNev()
        {
            List<string> szolgaltatasokneve = new List<string>();
            foreach(var sz in szolgalatasok)
            {
                szolgaltatasokneve.Add(sz.szolgalatasNev);
            }
            return szolgaltatasokneve;
        }
        public override string ToString()
        {
            return $"{szakNev},{szolgalatasok}";
        }
    }
}
