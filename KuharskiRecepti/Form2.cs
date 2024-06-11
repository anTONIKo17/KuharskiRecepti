using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KuharskiRecepti
{
    public partial class Form2 : Form
    {
        string path = "..\\..\\registracija.txt";
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonZapocni_Click(object sender, EventArgs e)
        {
            groupBoxRegistracija.Visible = true;

        }

        private void buttonSpremiRegistracija_Click(object sender, EventArgs e)
        {
            if (textBoxLozinka.Text.ToCharArray().Count()<8)
            {
                MessageBox.Show("Lozinka sadrži manje od 8 znakova!");
            }
            if(textBoxLozinka.Text!=textBoxPotvrdiLozinku.Text)
            {
                MessageBox.Show("Lozinka i potvrda lozinke se ne podudaraju!");
            }
            if(textBoxIme.Text==""||textBoxPrezime.Text==""||textBoxKorisnickoIme.Text==""||textBoxLozinka.Text==""||textBoxPotvrdiLozinku.Text=="")
            {
                MessageBox.Show("Nisu upisani svi traženi podatci!");
            }
            else
            {
                StreamReader sr = new StreamReader(path);
                string linija1 = sr.ReadLine();
                while (linija1 != null)
                {
                    string[] lin = linija1.Split('|');
                    if (textBoxKorisnickoIme.Text == lin[0])
                    {
                        textBoxKorisnickoIme.Text = "";
                        MessageBox.Show("Upisano korisničko ime već je iskorišteno i upotrebljeno.\nMolimo vas da smislite neko drugo korisničmo ime!");
                    }
                    linija1 = sr.ReadLine();
                }
                sr.Close();
                if (textBoxKorisnickoIme.Text != "")
                {
                    string linija2 = textBoxKorisnickoIme.Text + "|" + textBoxLozinka.Text;
                    StreamWriter sw = new StreamWriter(path, true);
                    sw.WriteLine(linija2);
                    textBoxIme.Text = "";
                    textBoxPrezime.Text = "";
                    textBoxKorisnickoIme.Text = "";
                    textBoxLozinka.Text = "";
                    textBoxPotvrdiLozinku.Text = "";
                    MessageBox.Show("Podatci su spremljeni!");
                    sw.Close();
                    Form3 Form3 = new Form3();
                    Form3.ShowDialog();
                    this.Close();
                }
            }
        }

        private void buttonZatvori2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
