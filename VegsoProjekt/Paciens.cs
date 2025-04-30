using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegsoProjekt
{
    internal class Paciens:Szemely
    {
        public string EgeszsegugyiMult { get; set; }
        public string BiztositoSzam { get; set; }

        public Paciens()
        {

        }
        public Paciens(string EgeszsegugyiMult, string BiztositoSzam)
        {
            this.EgeszsegugyiMult = EgeszsegugyiMult;
            this.BiztositoSzam = BiztositoSzam;
            
        }

        public string GetPatciensAdatok()
        {
            return $"{GetNev()} - BiztosioSzam: {BiztositoSzam}";
        }
    }
}
