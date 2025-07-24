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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\kalho\\source\\repos\\EmployeeManWinforms\\Test.mdf;Integrated Security=True;Connect Timeout=30");
                var adp = new SqlDataAdapter($"DELETE FROM emp WHERE name='{textBox1}'; ", con);
                DataSet ds = new DataSet();
                con.Open();
                adp.Fill(ds);
                if (ds.HasChanges())
                {
                    MessageBox.Show("Deleted!");
                }
                else
                {
                    MessageBox.Show("Not found");
                }
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
