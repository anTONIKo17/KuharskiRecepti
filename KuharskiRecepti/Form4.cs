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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonMoji_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void buttonZatvori4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUnos_Click_1(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }
    }
}
