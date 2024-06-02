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
        string path = "registracija.txt";
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
            if(textBoxIme.Text==""||textBoxPrezime.Text==""||textBoxKorisnickoIme.Text==""||textBoxLozinka.Text==""||textBoxPotvrdiLozinku.Text=="")
            {
                MessageBox.Show("Nisu upisani svi traženi podatci!");
            }
            else
            {
                string linija = textBoxIme.Text + "|" + textBoxPrezime.Text + "|" + textBoxKorisnickoIme.Text + "|" + textBoxLozinka.Text + "|" + textBoxPotvrdiLozinku.Text;
                StreamWriter sw = new StreamWriter(path, true);
                sw.WriteLine(linija);
                textBoxIme.Text = "";
                textBoxPrezime.Text = "";
                textBoxKorisnickoIme.Text = "";
                textBoxLozinka.Text = "";
                textBoxPotvrdiLozinku.Text = "";
                MessageBox.Show("Podatci su spremljeni!");
                sw.Close();
            }
        }
    }
}
