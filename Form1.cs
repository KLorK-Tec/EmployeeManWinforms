using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer;

namespace EmployeeManWinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //public string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\kalho\\source\\repos\\EmployeeManWinforms\\Test.mdf;Integrated Security=True;Connect Timeout=30";

        private void button1_Click(object sender, EventArgs e)
        {

            //var con = new SqlConnection();
            //con.ConnectionString = constr;
            //SqlDataAdapter adp = new SqlDataAdapter("INSERT INTO emp(id,name,joined) VALUES (1,'jafar','2025')",con);
            //DataSet ds = new DataSet();
            //con.Open();
            //adp.Fill(ds);
            //con.Close();
            //these are from before so i kept it just in case things gone wrong
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\kalho\\source\\repos\\EmployeeManWinforms\\Test.mdf;Integrated Security=True;Connect Timeout=30");
                var adp = new SqlDataAdapter($"SELECT * FROM emp", con);
                DataTable dt = new DataTable();
                con.Open();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DefaultCellStyle.BackColor = Color.LightGray;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
