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

                //var con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\kalho\\source\\repos\\EmployeeManWinforms\\Test.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\kalho\\source\\repos\\EmployeeManWinforms\\Test.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    string query = "DELETE FROM emp WHERE name = @name";
                    using (var cm = new SqlCommand(query, con))
                    {
                        cm.Parameters.AddWithValue("@name", textBox1.Text);
                        con.Open();
                        int rowsAffected = cm.ExecuteNonQuery();
                        con.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Deleted!");
                        }
                        else
                        {
                            MessageBox.Show("Not found!");
                        }
                    }
                }
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
