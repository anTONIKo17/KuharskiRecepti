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

                string linija2 = textBoxIme.Text + "|" + textBoxPrezime.Text + "|" + textBoxKorisnickoIme.Text + "|" + textBoxLozinka.Text;
                StreamWriter sw = new StreamWriter("registracija.txt");
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
            }
        }

        private void buttonZatvori2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
