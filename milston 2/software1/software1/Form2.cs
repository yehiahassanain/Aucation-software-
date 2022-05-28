using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace software1
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        string ordb = "Data source =orcl ;User Id=scott ;Password=tiger;";
        OracleConnection conn;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select PASSWORD from AUCATION_USER where EMAIL=:email ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("email",t_username.Text);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if( t_password.Text == dr[0].ToString())
                {
                    MessageBox.Show("login successful");
                }
                else
                {
                    MessageBox.Show("Incorrect Password ,Login Failed");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Email ,Login Failed");

            }
            dr.Close();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
