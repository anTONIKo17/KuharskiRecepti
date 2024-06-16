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
    public partial class Form5 : Form
    {
        string path = "..\\..\\registracija.txt";
        string path1 = "..\\..\\recept.txt";
        string path2 = "..\\..\\postupak.txt";
        string path3 = "..\\..\\sastojci.txt";
        public Form5()
        {
            InitializeComponent();
        }

        private void buttonSastojci_Click(object sender, EventArgs e)
        {
            groupBoxUnosSastojaka.Visible = true;
        }

        private void buttonOpis_Click(object sender, EventArgs e)
        {
            groupBoxOpisPostupka.Visible = true;
        }

        private void buttonZatvori5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSpremiOsnovno_Click(object sender, EventArgs e)
        {
            int t = 0;
            if(textBoxNazivR.Text==""||maskedTextBoxBroj.Text==""||textBoxKorisIme.Text=="")
            {
                MessageBox.Show("Nisu uneseni naziv recepta, broj sastojaka ili korisničko ime!");
            }
            if(radioButton1.Checked==false&&radioButton2.Checked==false&&radioButton3.Checked==false&&radioButton4.Checked==false&&radioButton5.Checked==false)
            {
                MessageBox.Show("Nije odabrano nijedno ponuđeno vrijeme potrebno za pripremu!");
            }
            if(textBoxKorisIme.Text != "")
            {
                StreamReader sr = new StreamReader(path);
                string linija = sr.ReadLine();
                while(linija != null)
                {
                    string[] lin = linija.Split('|');
                    if (textBoxKorisIme.Text == lin[0])
                    {
                        t = 1;
                    }
                    linija = sr.ReadLine();
                }
                sr.Close();
                if(t == 0)
                {
                    MessageBox.Show("Uneseno korisničko ime nije pronađeno, provjerite jeste li unijeli točno ime!");
                }
                else
                {
                    if (radioButton1.Checked == true)
                    {
                        StreamWriter sw = new StreamWriter(path1, true);
                        string linija1 = textBoxKorisIme.Text + '|' + textBoxNazivR.Text + '|' + maskedTextBoxBroj.Text + '|' + radioButton1.Text;
                        sw.WriteLine(linija1);
                        sw.Close();
                        MessageBox.Show("Podatci su uspješno uneseni!");
                    }
                    if (radioButton2.Checked == true)
                    {
                        StreamWriter sw = new StreamWriter(path1, true);
                        string linija1 = textBoxKorisIme.Text + '|' + textBoxNazivR.Text + '|' + maskedTextBoxBroj.Text + '|' + radioButton2.Text;
                        sw.WriteLine(linija1);
                        sw.Close();
                        MessageBox.Show("Podatci su uspješno uneseni!");
                    }
                    if (radioButton3.Checked == true)
                    {
                        StreamWriter sw = new StreamWriter(path1, true);
                        string linija1 = textBoxKorisIme.Text + '|' + textBoxNazivR.Text + '|' + maskedTextBoxBroj.Text + '|' + radioButton3.Text;
                        sw.WriteLine(linija1);
                        sw.Close();
                        MessageBox.Show("Podatci su uspješno uneseni!");
                    }
                    if (radioButton4.Checked == true)
                    {
                        StreamWriter sw = new StreamWriter(path1, true);
                        string linija1 = textBoxKorisIme.Text + '|' + textBoxNazivR.Text + '|' + maskedTextBoxBroj.Text + '|' + radioButton4.Text;
                        sw.WriteLine(linija1);
                        sw.Close();
                        MessageBox.Show("Podatci su uspješno uneseni!");
                    }
                    if (radioButton5.Checked == true)
                    {
                        StreamWriter sw = new StreamWriter(path1, true);
                        string linija1 = textBoxKorisIme.Text + '|' + textBoxNazivR.Text + '|' + maskedTextBoxBroj.Text + '|' + radioButton5.Text;
                        sw.WriteLine(linija1);
                        sw.Close();
                        MessageBox.Show("Podatci su uspješno uneseni!");
                    }
                }
            }
        }

        private void buttonSpremiSastojak_Click(object sender, EventArgs e)
        {
            if(textBoxKolicina.Text==""||textBoxSastojak.Text==""||comboBoxKolicina.Text==""||textBoxKorisIme.Text==""||textBoxNazivR.Text=="")
            {
                MessageBox.Show("Nisu uneseni svi potrebni podatci za sastojak!");
            }
            else
            {
                StreamWriter sw = new StreamWriter(path3, true);
                string linija;
                if(checkBoxPosljednji.Checked==false)
                {
                    linija = textBoxKorisIme.Text + '|' + textBoxNazivR.Text + '|' + textBoxSastojak.Text + " " + textBoxKolicina.Text + " " + comboBoxKolicina.Text;
                    sw.WriteLine(linija);
                    textBoxSastojak.Text = "";
                    textBoxKolicina.Text = "";
                    comboBoxKolicina.Text = "";
                }
                if(checkBoxPosljednji.Checked==true)
                {
                    linija = textBoxKorisIme.Text + '|' + textBoxNazivR.Text + '|' + textBoxSastojak.Text + " " + textBoxKolicina.Text + " " + comboBoxKolicina.Text;
                    sw.WriteLine(linija);
                    MessageBox.Show("Uspješno su uneseni svi sastojci za recept!");
                    textBoxSastojak.Text = "";
                    textBoxKolicina.Text = "";
                    comboBoxKolicina.Text = "";
                }
                sw.Close();
            }
        }

        private void buttonSpremiPostupak_Click(object sender, EventArgs e)
        {
            if(textBoxOpisPostupka.Text==""||textBoxKorisIme.Text==""||textBoxNazivR.Text=="")
            {
                MessageBox.Show("Nije upisano ništa za opis postupka niti korisničko ime!");
            }
            else
            {
                StreamWriter sw = new StreamWriter(path2, true);
                string linija = textBoxKorisIme.Text + '|' + textBoxNazivR.Text + '|' + textBoxOpisPostupka.Text;
                sw.WriteLine(linija);
                sw.Close();
                textBoxOpisPostupka.Text = "";
                MessageBox.Show("Uspješno je unesen opis postupka!");
            }
        }


    }
}
