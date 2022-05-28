using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace software1
{
    public partial class Form6 : Form
    {
        CrystalReport1 CR;
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, textBox1.Text);
            crystalReportViewer1.ReportSource = CR;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport1();
        }
    }
}
