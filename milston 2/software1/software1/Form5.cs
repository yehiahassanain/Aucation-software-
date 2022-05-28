using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace software1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void rigisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 r = new Form4();
            r.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 l = new Form2();
            l.Show();
        }

        private void displayItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 d = new Form1();
            d.Show();
        }

        private void editPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 edit  = new Form3();
            edit.Show();
        }

        private void reportOfProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 report = new Form6();
            report.Show();
        }

        private void reportOfUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 report = new Form8();
            report.Show();
        }
    }
}
