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
    public partial class Form7 : Form
    {
        string path = "..\\..\\registracija.txt";
        string path1 = "..\\..\\recept.txt";
        string path3 = "..\\..\\sastojci.txt";
        public Form7()
        {
            InitializeComponent();
        }

        private void buttonZatvori7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPotvrdi7_Click(object sender, EventArgs e)
        {
            int t = 0;
            if (textBoxKorisnicko7.Text == "")
            {
                MessageBox.Show("Niste unijeli korisničko ime!");
            }
            if (textBoxKorisnicko7.Text != "")
            {
                StreamReader sr = new StreamReader(path);
                string linija = sr.ReadLine();
                while (linija != null)
                {
                    string[] lin = linija.Split('|');
                    if (textBoxKorisnicko7.Text == lin[0])
                    {
                        t = 1;
                    }
                    linija = sr.ReadLine();
                }
                sr.Close();
                if (t == 0)
                {
                    MessageBox.Show("Uneseno korisničko ime nije pronađeno, provjerite jeste li unijeli točno ime!");
                }
                else
                {
                    groupBoxGeneriraj.Visible = true;
                    groupBoxNajpovoljniji.Visible = true;
                }
            }
        }

        private void buttonGeneriraj_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            int max = 0;
            int t = -1; ;
            string tekst = null;
            StreamReader sr = new StreamReader(path1);
            string linija = sr.ReadLine();
            while (linija != null)
            {
                string[] lin = linija.Split('|');
                if (lin[0] == textBoxKorisnicko7.Text)
                {
                    list.Add(lin[1]);
                    t++;
                }
                linija = sr.ReadLine();
            }
            sr.Close();
            StreamReader sr1 = new StreamReader(path3);
            string linija1 = sr1.ReadLine();
            while (linija1 != null)
            {
                string[] lin1 = linija1.Split('|');
                string[] lin2 = lin1[0].Split(' ');
                if (lin1[0]==textBoxKorisnicko7.Text)
                {
                    foreach (string s in list)
                    {
                        {
                            if (s == lin1[1])
                            {
                                if (textBoxSastojak1.Text == lin2[0])
                                {
                                    textBoxNajpovoljniji.Text = s;
                                }
                                if (textBoxSastojak2.Text == lin2[0])
                                {
                                    textBoxNajpovoljniji.Text = s;
                                }
                                if (textBoxSastojak3.Text == lin2[0])
                                {
                                    textBoxNajpovoljniji.Text = s;
                                }
                                if (textBoxSastojak4.Text == lin2[0])
                                {
                                    textBoxNajpovoljniji.Text = s;
                                }
                                if (textBoxSastojak5.Text == lin2[0])
                                {
                                    textBoxNajpovoljniji.Text = s;
                                }
                                if (textBoxSastojak6.Text == lin2[0])
                                {
                                    textBoxNajpovoljniji.Text = s;
                                }
                            }
                        }
                    }
                }
                linija1 = sr1.ReadLine();
            }
            sr1.Close();
        }

    }
}
                            

