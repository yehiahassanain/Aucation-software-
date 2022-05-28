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
    public partial class Form4 : System.Windows.Forms.Form
    {
        string ordb = "Data Source = orcl; User Id =hr; Password =hr;";
        OracleConnection conn;
        public Form4()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into AUCATION_USER (NAME_USER, EMAIL, PASSWORD, USER_ID)  values  (:name, :email, :password, :id )";
            cmd.Parameters.Add("name", textBox1.Text);
            cmd.Parameters.Add("email", textBox2.Text);
            cmd.Parameters.Add("password", textBox3.Text);
            cmd.Parameters.Add("id", comboBox1.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                comboBox1.Items.Add(comboBox1.Text);
                MessageBox.Show("you have been registered successfully");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
