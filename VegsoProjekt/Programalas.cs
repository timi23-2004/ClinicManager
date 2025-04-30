using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VegsoProjekt
{
    public partial class Programalas : Form
    {
        private Adatbazis adatbazis= new Adatbazis();
        private Klinika klinika=Klinika.Peldany();
        private Szakrendeles szakrendeles;
        bool delet=false;
        public Programalas()
        {
            InitializeComponent();
            ProgramalasIopont.CustomFormat = "yyyy-MM-dd";
            ProgramalasIopont.Format = DateTimePickerFormat.Custom;
            SzolgaltatasokBox.Items.Clear();
            List<Szakrendeles> Szaklist = klinika.szakrendelesList;
            foreach (var szak in Szaklist)
            {
                SzakBox.Items.Add(szak.szakNev);

            }
            
        }
        private void Clock_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            for (int i = 0; i < Clock.Items.Count; i++)
            {
                if (Clock.SelectedIndex != i)
                {
                    Clock.SetItemChecked(i, false);

                }

            }
        }

        private void visszaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FoForm fo = new FoForm();
            fo.ShowDialog();
        }
        private void programálásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delet = false;
            Proglemondasa.Visible = false;
            AddProgramalas.Visible = true;
            Progmodositasa.Visible = false;
        }

       

        private void programálásLemondásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delet = true;
            Proglemondasa.Visible = true;
            AddProgramalas.Visible = false;
            Progmodositasa.Visible = false;
        }
        private bool igenMegnyomva = false;
        private void buttonIgen_Click(object sender, EventArgs e)
        {
            panel1.Visible=false;
            igenMegnyomva = true;
            

        }
        private void Cnp_TextChanged(object sender, EventArgs e)
        {
            if(igenMegnyomva)
            {
                string cnp = Cnp.Text;
                if (!string.IsNullOrEmpty(cnp))
                {
                    Thread thread = new Thread(() =>
                    {


                        var paciensAdatok = klinika.GetPaciensAdatok(cnp);

                        if (paciensAdatok != null)
                        {

                            this.Invoke(new Action(() =>
                            {
                                Paciensnev.Text = paciensAdatok.Nev;
                                telefonszam.Text = paciensAdatok.TelefonSzam;
                                Egmult.Text = paciensAdatok.EgeszsegugyiMult;
                                Biztszam.Text = paciensAdatok.BiztositoSzam;
                            }));
                        }
                        else
                        {

                            this.Invoke(new Action(() =>
                            {
                                MessageBox.Show("Nincs ilyen páciens az adatbázisban.");
                            }));
                        }

                    });

                    thread.Start();
                }
                else
                {

                    this.Invoke(new Action(() =>
                    {
                        MessageBox.Show("Kérlek, add meg a CNP-t.");
                    }));
                }
            }
        }
        private bool nemMegyomva = false;
        private void ButtonNem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            nemMegyomva = true;
        }

        private void SzakBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SzolgaltatasokBox.Text = "";
            SzolgaltatasokBox.Items.Clear();
            DoktorokBox.Text = "";
            DoktorokBox.Items.Clear();
            if (SzakBox.SelectedItem != null)
            {
                string szak = SzakBox.SelectedItem.ToString();


                if (!string.IsNullOrEmpty(szak))
                {
                    try {
                        var szakrendeles = klinika.szakrendelesList
                                    .FirstOrDefault(szakk => szakk.szakNev == szak);
                        if (szakrendeles != null)
                        {
                            List<string> szolgalatasNevek = szakrendeles.getSzolgalatasListaNev();
                            foreach (var s in szolgalatasNevek)
                            {
                                SzolgaltatasokBox.Items.Add(s);
                            }
                        }

                     }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Hiba történt az adatok betöltése során: " + ex.Message);
                    }
                }
                List<string> dokik = adatbazis.GetDoktorneve(szak);
                foreach (var dok in dokik)
                {
                    DoktorokBox.Items.Add(dok);

                }

            }
                

            
            /*string szak = SzakBox.SelectedItem.ToString();
            List<string> Szolgaltataslist = adatbazis.GetSzolgaltatasok(szak);
            foreach (var szolg in Szolgaltataslist)
            {
                SzolgaltatasokBox.Items.Add(szolg);

            }*/

        }

        private void AddProgramalas_Click(object sender, EventArgs e)
        {
            try
            {
                if (nemMegyomva)
                {
                    string paciensCnp = Cnp.Text;
                    string doktorNev = DoktorokBox.SelectedItem.ToString();
                    DateTime datum = ProgramalasIopont.Value;
                    int ora = int.Parse(Clock.SelectedItem.ToString());
                    DateTime dateTime = programalasDatum(datum, ora);
                    string nev = Paciensnev.Text;
                    string telefonSzam = telefonszam.Text;
                    string egeszsegugyiMult = Egmult.Text;
                    string biztositoSzam = Biztszam.Text;
                    string dokiCnp = adatbazis.GetDoktornevecnp(doktorNev);
                    string szolgaltatasNeve = SzolgaltatasokBox.SelectedItem.ToString();
                    adatbazis.InsertSzemely(paciensCnp, nev, telefonSzam, "Paciens");
                    adatbazis.InsertProgramalas(paciensCnp, szolgaltatasNeve, dokiCnp, dateTime);
                    adatbazis.InsertPaciens(paciensCnp, egeszsegugyiMult, biztositoSzam);
                    klinika.frissitesKlinika();
                }
                
                    
                    klinika.frissitesKlinika();
                    Cnp.Text = "";
                    Paciensnev.Text = "";
                    telefonszam.Text = "";
                    Egmult.Text = "";
                    Biztszam.Text = "";
                    Clock.Visible = false;
                    SzakBox.Text = "";
                    SzolgaltatasokBox.Text = "";
                    DoktorokBox.Text = "";
                    MessageBox.Show("Sikeres programalas!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sikertelen programalas!");
            }
            klinika.frissitesKlinika();
            Cnp.Text = "";
            Paciensnev.Text = "";
            telefonszam.Text = "";
            Egmult.Text = "";
            Biztszam.Text = "";
            Clock.Visible = false;
            SzakBox.Text = "";
            SzolgaltatasokBox.Text = "";
            DoktorokBox.Text = "";
            //MessageBox.Show("Sikeres programalas!");
        }
        public DateTime programalasDatum(DateTime be, int orabe)
        {
             DateTime uj=new DateTime(be.Year,be.Month,be.Day,orabe,0,0);
            return uj;
        }

        private void ProgramalasIopont_ValueChanged(object sender, EventArgs e)
        {
            Clock.Visible = true;
            Clock.Items.Clear();
            DateTime be = ProgramalasIopont.Value;
            string doktorNev = DoktorokBox.SelectedItem.ToString();
            string dokiCnp = adatbazis.GetDoktornevecnp(doktorNev);
            string szolgaltatasNeve = SzolgaltatasokBox.SelectedItem.ToString();

            var foglaltIdopontok= from idok in klinika.programalasList
                                  where idok.Idopont.Year==be.Year
                                  where idok.Idopont.Month==be.Month
                                  where idok.Idopont.Day==be.Day
                                  where idok.DoktorCnp==dokiCnp
                                  where idok.SzolgaltatasNev==szolgaltatasNeve
                                  select idok.Idopont;
            List<int> list = new List<int>();
            if (delet==false)
            {
                foreach (var i in foglaltIdopontok)
                {
                    list.Add(i.Hour);
                }
                for (int i = 8; i < 16; ++i)
                {
                    bool van = false;
                    foreach (var j in list)
                    {
                        if (i == j)
                            van = true;
                        break;
                    }
                    if (van == false)
                    {
                        Clock.Items.Add(i);
                    }
                }
            }
            else
            {
                foreach (var i in foglaltIdopontok)
                {
                    list.Add(i.Hour);
                }
                for (int i = 8; i < 16; ++i)
                {
                    bool van = false;
                    foreach (var j in list)
                    {
                        if (i == j)
                            van = true;
                       
                    }
                    if (van == true)
                    {
                        Clock.Items.Add(i);
                    }
                }
            }
           
            

        }

        private void Proglemondasa_Click(object sender, EventArgs e)
        {
            
            string paciensCnp = Cnp.Text;
            string doktorNev = DoktorokBox.SelectedItem.ToString();
            DateTime datum = ProgramalasIopont.Value;
            int ora = int.Parse(Clock.SelectedItem.ToString());
            DateTime dateTime = programalasDatum(datum, ora);
            string nev = Paciensnev.Text;
            string telefonSzam = telefonszam.Text;
            string egeszsegugyiMult = Egmult.Text;
            string biztositoSzam = Biztszam.Text;
            string dokiCnp = adatbazis.GetDoktornevecnp(doktorNev);
            string szolgaltatasNeve = SzolgaltatasokBox.SelectedItem.ToString();
            adatbazis.DeleteProgramalast(paciensCnp,szolgaltatasNeve,dokiCnp,dateTime);
            klinika.frissitesKlinika();
            Cnp.Text = "";
            Paciensnev.Text = "";
            telefonszam.Text = "";
            Egmult.Text = "";
            Biztszam.Text = "";
            Clock.Visible = false;
            SzakBox.Text = "";
            SzolgaltatasokBox.Text = "";
            DoktorokBox.Text = "";
            MessageBox.Show("Sikeres programalas!");

        }
    }
 }



