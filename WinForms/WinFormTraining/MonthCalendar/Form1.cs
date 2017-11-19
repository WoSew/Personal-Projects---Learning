using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_currentDate.Text = monthCalendar1.TodayDate.ToShortDateString();
        }

        private void btn_updateDate_Click(object sender, EventArgs e)
        {
            monthCalendar1.TodayDate=(dtp_newDate.Value);
            tb_currentDate.Text = monthCalendar1.TodayDate.ToShortDateString();

        }

        private void btn_weeksNumbers_Click(object sender, EventArgs e)
        {
            monthCalendar1.ShowWeekNumbers = !monthCalendar1.ShowWeekNumbers;

            //if (monthCalendar1.ShowWeekNumbers) btn_weeksNumbers.Text = "Hide weeks numbers";
            //else btn_weeksNumbers.Text = "Show weeks numbers";
        
            var s = monthCalendar1.ShowWeekNumbers ? btn_weeksNumbers.Text = "Hide weeks numbers" : btn_weeksNumbers.Text = "Show weeks numbers";
        }
    }
}
