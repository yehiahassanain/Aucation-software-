using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace software1
{
    public partial class Form3 : System.Windows.Forms.Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet data;
        public Form3()
        {
            InitializeComponent();
        }

  
        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data Source = orcl; User Id =hr; Password =hr;";
            string cmdstr = "select * from PRODUCT where ADVERTISER_ID = :id";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("id", textBox1.Text);
            data = new DataSet();
            adapter.Fill(data);
            dataGridView1.DataSource = data.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(data.Tables[0]);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
