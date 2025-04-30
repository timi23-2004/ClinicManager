using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VegsoProjekt
{
    public partial class Belsos : Form
    {
        private Adatbazis adatbazis;
        Klinika klinika= Klinika.Peldany();
        
        public Belsos()
        {
            InitializeComponent();
            adatbazis = new Adatbazis();
            List<string> Szaklist = adatbazis.GetSzakrendelesek();
            foreach (var szak in Szaklist)
            {
                SzakokBox.Items.Add(szak);
                SzakBoxDoki.Items.Add(szak);

            }
        }
        private void szakrendelésHozzáadásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Szak1.Visible = true;
            Szakneve.Visible = true;
            Szakadd.Visible = true;
            SzakokBox.Visible = false;
            Szolgneve.Visible = false;
            Sz1.Visible = false;
            Sz2.Visible = false;
            Szolgara.Visible = false;
            Szolgadd.Visible = false;
            Cnp.Visible = false;
            Nev.Visible = false;
            Telefonszam.Visible = false;
            SzakBoxDoki.Visible = false;
            D1.Visible = false;
            D2.Visible = false;
            D3.Visible = false;
            D4.Visible = false;
            Doktoradd.Visible = false;
        }
        private void szolgáltatásToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Szakadd.Visible = false;
            Szak1.Visible = true;
            Szakneve.Visible = false;
            SzakokBox.Visible = true;
            Szolgneve.Visible = true;
            Sz1.Visible = true;
            Sz2.Visible = true;
            Szolgara.Visible=true;
            Szolgadd.Visible = true;
            Cnp.Visible = false;
            Nev.Visible = false;
            Telefonszam.Visible = false; 
            SzakBoxDoki.Visible = false;
            D1.Visible = false;
            D2.Visible = false;
            D3.Visible = false;
            D4.Visible = false;
            Doktoradd.Visible = false;
        }
        private void doktorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Szak1.Visible = false;
            Szakneve.Visible = false;
            Szakadd.Visible = false;
            SzakokBox.Visible = false;
            Szolgneve.Visible = false;
            Sz1.Visible = false;
            Sz2.Visible = false;
            Szolgara.Visible = false;
            Szolgadd.Visible = false;
            Cnp.Visible = true;
            Nev.Visible = true;
            Telefonszam.Visible=true; 
            SzakBoxDoki.Visible=true;
            D1.Visible=true; 
            D2.Visible=true;
            D3.Visible=true;
            D4.Visible=true;
            Doktoradd.Visible=true;
        }

        private async void Szakadd_Click(object sender, EventArgs e)
        {
            SzakokBox.Items.Clear();
            string szakNev = Szakneve.Text;
            adatbazis.InsertSzakrendele(szakNev);
            List<string> Szaklist = await adatbazis.GetSzakrendelesekAsync();
            foreach (var szak in Szaklist)
            {
                SzakokBox.Items.Add(szak);
                SzakBoxDoki.Items.Add(szak);
            }
            Szakrendeles szakrendeles = new Szakrendeles(szakNev);
            klinika.szakrendelesList.Add(szakrendeles);
            Szakneve.Text = "";
        }


        private void Szolgadd_Click(object sender, EventArgs e)
        {
            string szolgnev= Szolgneve.Text;
            int ar=int.Parse(Szolgara.Text);
            string szaknev=SzakokBox.SelectedItem.ToString();
            Szakrendeles szakrendeles = new Szakrendeles(szaknev);
            szakrendeles.addSzolgalatas(new Szolgaltatas(szolgnev, ar,szaknev));
            adatbazis.InsertSzolgaltatas(szolgnev, ar, szaknev);
            /*Szolgaltatas szolgaltatas = new Szolgaltatas(szolgnev, ar,szaknev);
            foreach(var sz in klinika.szakrendelesList)
            {
                if (sz.szakNev == szaknev)
                    sz.addSzolgalatas(szolgaltatas);
            }*/
            Szolgneve.Text = "";
            Szolgara.Text = "";
        }

        private void Doktoradd_Click(object sender, EventArgs e)
        {
            string cnp = Cnp.Text;
            string nev=Nev.Text;
            string telefonszam = Telefonszam.Text;
            string szakterulet= SzakBoxDoki.SelectedItem.ToString();
            adatbazis.InsertSzemely(cnp, nev, telefonszam, "Doktor");
            adatbazis.InsertDoktor(cnp, szakterulet);
            Cnp.Text = "";
            Nev.Text = "";
            Telefonszam.Text = "";

        }

        private void Belsos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FoForm f=new FoForm();
            f.Show();
        }
    }

}
