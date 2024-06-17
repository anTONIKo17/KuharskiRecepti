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
    public partial class Form6 : Form
    {
        string path = "..\\..\\registracija.txt";
        string path1 = "..\\..\\recept.txt";
        string path2 = "..\\..\\postupak.txt";
        string path3 = "..\\..\\sastojci.txt";
        public Form6()
        {
            InitializeComponent();
        }

        private void buttonZatvori6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            int t = 0;
            if (textBoxKorisnickoMoji.Text == "")
            {
                MessageBox.Show("Niste unijeli korisničko ime!");
            }
            if (textBoxKorisnickoMoji.Text != "")
            {
                StreamReader sr = new StreamReader(path);
                string linija = sr.ReadLine();
                while (linija != null)
                {
                    string[] lin = linija.Split('|');
                    if (textBoxKorisnickoMoji.Text == lin[0])
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
                    StreamReader sr1 = new StreamReader(path1);
                    string linija1 = sr1.ReadLine();
                    List<string> lst = new List<string>();
                    while (linija1 != null)
                    {
                        string[] lin1 = linija1.Split('|');
                        if (lin1[0] == textBoxKorisnickoMoji.Text)
                        {
                            lst.Add(lin1[1]);
                        }
                        linija1 = sr1.ReadLine();
                    }
                    sr.Close();
                    listBoxMojiRecepti.DataSource = lst;
                }
            }
        }

        private void buttonSortiraj_Click(object sender, EventArgs e)
        {
            if (radioButtonUzlazno.Checked == true)
            {
                
            }
            if (radioButtonSilazno.Checked == true)
            {

            }
        }

        private void listBoxMojiRecepti_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBoxRecept.Visible = true;
            string tekst = null; 
            StreamReader sr = new StreamReader(path3);
            string linija = sr.ReadLine();
            while (linija != null)
            {
                string[] lin = linija.Split('|');
                if (lin[0] == textBoxKorisnickoMoji.Text && listBoxMojiRecepti.SelectedItem.ToString() == lin[1])
                {
                    textBoxNaziv.Text = lin[1];
                    if (lin[1] == listBoxMojiRecepti.SelectedItem.ToString())
                    {
                        string[] lin1 = lin[2].Split(' ');
                        tekst = tekst + " " + lin1[0] + " " + lin1[1] + " " + lin1[2];
                        if (lin[2].ToCharArray().Count() >= 20)
                        {
                            string tekst1 = lin1[3];
                            tekst = tekst + " " + tekst1;
                        }
                    }
                }
                linija = sr.ReadLine();
            }
            textBoxSastojci.Text = tekst;
            sr.Close();
            StreamReader sr1 = new StreamReader(path2);
            string linija1 = sr1.ReadLine();
            while(linija1!= null)
            {
                string[] lin = linija1.Split('|');
                if (lin[0] == textBoxKorisnickoMoji.Text && lin[1]==textBoxNaziv.Text)
                {
                    textBoxPostupak6.Text = lin[2];
                }
                linija1= sr1.ReadLine();
            }
            sr1.Close();
        }
    }
}