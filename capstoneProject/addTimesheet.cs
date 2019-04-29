using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace capstoneProject
{
    public partial class addTimesheet : UserControl
    {
        public addTimesheet()
        {
            InitializeComponent();
            dtp_clockIn.Value = DateTime.Today;
            dtp_clock_out.Value = DateTime.Today;
            UpdateHours();
        }

        private void Txt_totalBreak_TextChanged(object sender, EventArgs e)
        {
            UpdateHours();
        }

        private void Dtp_clock_out_ValueChanged(object sender, EventArgs e)
        {
            UpdateHours();

        }

        private void Dtp_clockIn_ValueChanged(object sender, EventArgs e)
        {
            UpdateHours();
        }

        private void UpdateHours()
        {
            int hours=0, minutes, seconds;
            DateTime Tdate;
            string date;

            Tdate = dtp_clockIn.Value.Date;
            date = Tdate.ToShortDateString();

            // CALCULATES HOURS
            if (dtp_clockIn.Value.Day < dtp_clock_out.Value.Day)
            {
                if (dtp_clockIn.Value.Hour > 12)
                {
                    hours = (((dtp_clock_out.Value.Day - dtp_clockIn.Value.Day) * 24) - (24 - ((12 - (dtp_clockIn.Value.Hour - 12)) + dtp_clock_out.Value.Hour)));
                }
                else
                {
                    hours = (((dtp_clock_out.Value.Day - dtp_clockIn.Value.Day) * 24) - (24 - ((12 - dtp_clockIn.Value.Hour) + dtp_clock_out.Value.Hour)));
                }
            }
            else if (dtp_clockIn.Value.Day == dtp_clock_out.Value.Day)
            {
                hours = dtp_clock_out.Value.Hour - dtp_clockIn.Value.Hour;
            }
            else
            {
                txt_hoursTotal.Text = "ERROR";
            }

            // CALCULATES MINUTES
            if (dtp_clock_out.Value.Minute > dtp_clockIn.Value.Minute)
            {
                minutes = dtp_clock_out.Value.Minute - dtp_clockIn.Value.Minute;
            }
            else
            {
                minutes = 60 - (dtp_clockIn.Value.Minute - dtp_clock_out.Value.Minute);
            }

            if (minutes == 60)
            {
                minutes = 0;
            }

            // CALCULATE SECONDS
            if (dtp_clock_out.Value.Second > dtp_clockIn.Value.Second)
            {
                seconds = dtp_clock_out.Value.Second - dtp_clockIn.Value.Second;
            }
            else
            {
                seconds = 60 - (dtp_clockIn.Value.Second - dtp_clock_out.Value.Second);
            }

            if (seconds == 60)
            {
                seconds = 0;
            }

            // INCLUDE TOTAL BREAK
            int totalBreak;

            if (!int.TryParse(txt_totalBreak.Text, out totalBreak))
            {
                txt_totalBreak.BackColor = Color.IndianRed;
            }
            else
            {
                txt_totalBreak.BackColor = Color.PaleGreen;
                if (totalBreak >= 60)
                {
                    totalBreak = totalBreak - 60;
                    hours = hours - 1;
                }
                if (minutes > totalBreak)
                {
                    minutes = minutes - totalBreak;
                }
                else if (totalBreak > minutes)
                {
                    totalBreak = totalBreak - minutes;
                    minutes = 60 - totalBreak;
                    hours = hours - 1;
                }
            }



            txt_hoursTotal.Text = $"{hours}:{minutes}:{seconds}";

            int ID_FALSE = 0;
            addTimesheetData timesheetInfo = new addTimesheetData(date, hours, minutes, seconds, ID_FALSE);
        }


        private void Txt_hoursTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }   
}
