using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EmployeeManWinforms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void sub_Click(object sender, EventArgs e)
        {
            try
            {
                var con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\kalho\\source\\repos\\EmployeeManWinforms\\Test.mdf;Integrated Security=True;Connect Timeout=30");
                var adp = new SqlDataAdapter($"INSERT INTO emp(name,joined) VALUES ('{tb1.Text}','{tb2.Text}')", con);
                DataSet ds = new DataSet();
                con.Open();
                adp.Fill(ds);
                con.Close();
                MessageBox.Show($"Added {tb1.Text}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(1);
            }
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
