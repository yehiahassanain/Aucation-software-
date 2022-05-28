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
    public partial class Form1 : Form
    {
        string ordb = "Data source =orcl ;User Id=scott ;Password=tiger;";
        OracleConnection conn;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
             conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DISPLAY_ITEMS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GET_ITEM";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", Convert.ToInt32(comboBox1.SelectedItem.ToString()));
            cmd.Parameters.Add("name", OracleDbType.Varchar2, 200).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("price", OracleDbType.Int32, ParameterDirection.Output);
            cmd.Parameters.Add("start_date", OracleDbType.Date, ParameterDirection.Output);
            cmd.Parameters.Add("end_date", OracleDbType.Date, ParameterDirection.Output);
            cmd.Parameters.Add("description", OracleDbType.Varchar2, 200).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            textBox5.Text = cmd.Parameters["name"].Value.ToString();
            textBox3.Text = cmd.Parameters["price"].Value.ToString();
            textBox4.Text = cmd.Parameters["start_date"].Value.ToString();
            textBox2.Text = cmd.Parameters["end_date"].Value.ToString();
            textBox1.Text = cmd.Parameters["description"].Value.ToString();

        }

       
    }
}
