using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProgressBar_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_activate_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wojse\Documents\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataAdapter adapter = new SqlDataAdapter("Select Count(*) From Login where USERNAME='"+tb_login.Text+"' AND PASSWORD='"+tb_password.Text+"'", connection);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            if (dataTable.Rows[0][0].ToString() == "1")
            {
                if (timer1.Enabled) timer1.Enabled = true;
                else timer1.Enabled = false;

                //timer1.Enabled = !timer1.Enabled;

                DialogResult result = MessageBox.Show("You have successfully logged in", "SINGED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    this.Close();

                }
            }

            else
                MessageBox.Show("Please Check Your username and password", "Wrong Username and/or Password",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pg_loadingBar.Increment(30);
        }
    }
}
