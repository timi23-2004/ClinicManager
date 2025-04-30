using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegsoProjekt
{
    internal class Klinika
    {
        private static Klinika peldany;
        private Adatbazis adatbazis;
        //public List<string> doktorList = new List<string>();
        //public List<string> paciensList = new List<string>();
       
        private Klinika(string klinikanev) 
        {
            this.klinikanev = klinikanev;
            adatbazis = new Adatbazis();
            szakrendelesList = new List<Szakrendeles>();
            szolgalatasList = new List<Szolgaltatas>();
            programalasList= new List<ProgramalaClass>();
            doktorList= new List<Doktor>();
            paciensList = new List<Paciens>();
    }
        public static Klinika Peldany()
        {
            if(peldany==null)
            {
                peldany = new Klinika("MEDCity");
            }
            return peldany;
        }
        public string klinikanev {get; set;}
        public List<Szakrendeles> szakrendelesList { get; set;}
        public List<Szolgaltatas> szolgalatasList { get; set;}
        public List<ProgramalaClass> programalasList { get; set;}
        public List<Doktor> doktorList { get; set;}
        public List<Paciens> paciensList { get; set;}
        public void frissitesKlinika()
        {
            this.doktorList.Clear();
            this.szakrendelesList.Clear();
            this.szolgalatasList.Clear();
            this.programalasList.Clear();
            this.doktorList.Clear();
            List<string> Szaklist = adatbazis.GetSzakrendelesek();
            foreach (var szak in Szaklist)
            {
                Szakrendeles szakrendeles = new Szakrendeles(szak);
                this.szakrendelesList.Add(szakrendeles);
                List<Szolgaltatas> szolgaltatasok = adatbazis.GetSzolgaltatasok(szak);
                szakrendeles.szolgalatasok = szolgaltatasok;

            }
            List<ProgramalaClass> programalasok = adatbazis.GetProgramalasok();
            foreach (var programalas in programalasok)
            {
                this.programalasList.Add(programalas);
            }
            
            List<Doktor> doktorok = adatbazis.GetDoktorok();
            foreach (var doktor in doktorok)
            {
                this.doktorList.Add(doktor);
            }
            List<Paciens> paciensek = adatbazis.GetPaciensek();
            foreach (var paciens in paciensek)
            {
                this.paciensList.Add(paciens);
            }
        }
        public Paciens GetPaciensAdatok(string cnp)
        {
            return paciensList.FirstOrDefault(p => p.Cnp == cnp);
        }
    }
}
