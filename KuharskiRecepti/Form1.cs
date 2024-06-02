using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuharskiRecepti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void prijavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.ShowDialog();
        }

        private void registracijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.ShowDialog();
        }

        private void promjenaLozinkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.ShowDialog();
        }

        private void instrukcijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Naša aplikacija poprilično je jednostavna za uporabu.\nSve što trebate učiniti je registrirati se i upisati sve važne informacije (sastojke i pripremu) o svome receptu kako bi se sačuvali.\nOsim pregleda recepata, naša aplikacija nudi i postavljanje fotografije recepta, sortiranje recepata te pretraživanje recepata po upisanim sastojcima.\nNadamo se da će vam naša aplikacija biti korisna i jednostavna!");
        }

        private void oAplikacijiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikacija je izrađena u svrhu završnog projekta nastave Informatike 3. razreda III. gimnazije, Split.\nAplikacija nije izrađena u komercijalne svrhe i svrhe krađe podataka!");
        }

        private void oKreatorimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kreatori su dvoje jako vrijednih, pametnih i marljivih ljudi koji su uložili puno truda u izradi ove aplikacije.\nOni su učenici 3.c razreda III. gimnazije, Split");
        }
    }
}
