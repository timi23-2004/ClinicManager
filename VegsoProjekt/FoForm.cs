using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VegsoProjekt
{
    public partial class FoForm : Form
    {
        private Adatbazis adatbazis = new Adatbazis();
        private Klinika klinika = Klinika.Peldany();
        public FoForm()
        {
            InitializeComponent();
            
                
                foreach (var szak in klinika.szakrendelesList)
                {
                    SzakCombo.Items.Add(szak.szakNev);

                }
            klinika.frissitesKlinika();
            kiirAdatok();

        }

        private void kiirAdatok()
        {
            if (klinika.szakrendelesList.Count == 0)
            {
                Console.WriteLine("Nincsenek elérhető szakterületek.");
                return;
            }
            foreach (var szakrendeles in klinika.szakrendelesList)
            {
                Console.WriteLine($"Szakterület: {szakrendeles.szakNev}");
                List<string> szolgaltatasNevek = szakrendeles.getSzolgalatasListaNev();
                if (szolgaltatasNevek.Count > 0)
                {
                    Console.WriteLine("  Szolgáltatások:");
                    foreach (var szolg in szolgaltatasNevek)
                    {
                        Console.WriteLine($"    - {szolg}");
                    }
                }
                else
                {
                    Console.WriteLine("  Nincsenek szolgáltatások a szakterülethez.");
                }
            }
            if(klinika.doktorList.Count == 0)
            {
                Console.WriteLine("Nincsenek elérhető doktorok.");
            }
            else
            {
                Console.WriteLine("Elérhető doktorok:");
                foreach (var doktor in klinika.doktorList)
                {
                    Console.WriteLine($"  - Név: {doktor.Nev}, CNP: {doktor.Cnp}, Szakterület: {doktor.Szakterulet}");
                }
            }

           
            if (klinika.paciensList.Count == 0)
            {
                Console.WriteLine("Nincsenek elérhető páciensek.");
            }
            else
            {
                Console.WriteLine("Elérhető páciensek:");
                foreach (var paciens in klinika.paciensList)
                {
                    Console.WriteLine($"  - Név: {paciens.Nev}, CNP: {paciens.Cnp}, Egészségügyi múlt: {paciens.EgeszsegugyiMult}");
                }
            }
            if (klinika.programalasList.Count == 0)
            {
                Console.WriteLine("Nincsenek elérhető programozások.");
            }
            else
            {
                Console.WriteLine("Elérhető programozások:");
                foreach (var programalas in klinika.programalasList)
                {
                    Console.WriteLine($"  - Pácienst CNP: {programalas.PaciensCnp}, Szolgáltatás: {programalas.SzolgaltatasNev}, Doktor CNP: {programalas.DoktorCnp}, Időpont: {programalas.Idopont}");
                }
            }
        }

        private void belsősAdatokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Belsos f1= new Belsos();
            f1.ShowDialog();
        }

        private void programálásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Programalas f2 = new Programalas();
            f2.ShowDialog();
        }
        private void információkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Infok.Visible = true;
            kep.Visible= true;
            SzakCombo.Visible = false;
            SzolgLista.Visible=false;
            label1.Visible = false;
        }

        private void szakrendelésekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Infok.Visible=false;
            kep.Visible=false;
            SzakCombo.Visible = true;
            SzolgLista.Visible = true;
            label1.Visible = true;
        }

        private void SzakCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SzolgLista.Items.Clear();
            string szak=SzakCombo.SelectedItem.ToString();
            var szolgaltatasok = from szakk in klinika.szakrendelesList
                                 where szakk.szakNev == szak
                                 from szolgaltatas in szakk.szolgalatasok
                                 select $"{szolgaltatas.szolgalatasNev} - Ár: {szolgaltatas.szolgalatasAra} RON";
            
            SzolgLista.Items.AddRange(szolgaltatasok.ToArray());

        }
    }
}
