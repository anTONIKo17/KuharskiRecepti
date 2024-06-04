using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuharskiRecepti
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            groupBoxPrijava.Visible = true;
        }

        private void buttonZapocniPromjenu_Click(object sender, EventArgs e)
        {
            groupBoxPromjenaLozinke.Visible = true;
        }

        private void buttonPrijaviSe_Click(object sender, EventArgs e)
        {
            if(textBoxUpisKorisnicko.Text==""||textBoxUpisLozinka.Text=="")
            {
                MessageBox.Show("Nisu uneseni svi potrebni podatci!");
            }
            else
            {
                StreamReader sr = new StreamReader("registracija.txt");
                string linija = sr.ReadLine();
                while(linija != null)
                {
                    string[] lin = linija.Split('|');
                    if (textBoxUpisKorisnicko.Text == lin[2] && textBoxUpisLozinka.Text == lin[3])
                    {
                        textBoxUpisKorisnicko.Text = "";
                        textBoxUpisLozinka.Text = "";
                        Form4 Form4 = new Form4();
                        Form4.ShowDialog();
                        this.Close();
                        break;
                    }
                    linija = sr.ReadLine();
                }

                if (textBoxUpisKorisnicko.Text != "" && textBoxUpisLozinka.Text != "")
                    {
                    MessageBox.Show("Vaši upisani podatci nisu pronađeni.\nDošlo je do pogreške pri upisu ili ako niste, trebate prvo izvršiti registraciju.");
                }
                sr.Close();
            }
        }

        private void buttomZatvori3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
