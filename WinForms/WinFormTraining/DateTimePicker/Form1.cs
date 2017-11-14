using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            dtp_current.Value = dtp_new.Value;
        }

        private void Btn_time_Click(object sender, EventArgs e)
        {
            dtp_time.Value = dtp_time.Value.AddHours(1);
        }

        private void Btn_Current_Time_Click(object sender, EventArgs e)
        {
            dtp_time.Value = DateTime.Now;
        }
    }
}
