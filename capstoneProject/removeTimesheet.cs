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
    public partial class removeTimesheet : UserControl
    {
        public removeTimesheet()
        {
            InitializeComponent();
        }

        private void Txt_timesheetID_TextChanged(object sender, EventArgs e)
        {
            int timesheetID;
            if (!int.TryParse(txt_timesheetID.Text, out timesheetID))
            {
                txt_timesheetID.BackColor = Color.IndianRed;
                lbl_timesheetValidationMessage.Text = "Enter a valid ID";
                
            }
            else
            {
                txt_timesheetID.BackColor = Color.PaleGreen;
                lbl_timesheetValidationMessage.Text = "Valid ID Entered";
                int FALSE_HOURS = 0, FALSE_MINUTES = 0, FALSE_SECONDS = 0;
                string FALSE_DATE="FALSE";
                bool returnInfo = true;

                clockInformation sendID_wFALSE = new clockInformation(FALSE_DATE, FALSE_HOURS, FALSE_MINUTES, FALSE_SECONDS, timesheetID, returnInfo);
                // return info
                txt_hoursWorked.Text = _hoursWorked.ToString();
                txt_timesheetDate.Text = _date;
                lbl_timesheetValidationMessage.Text = _message;
            }
            
        }

        private void Lbl_timesheetValidationMessage_Click(object sender, EventArgs e)
        {

        }

        private void Txt_hoursWorked_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dtp_dateReturned_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            txt_timesheetID.Clear();
            txt_timesheetDate.Clear();
            txt_hoursWorked.Clear();
        }


        public static int _hoursWorked;
        public static string _date, _message;

        private void Txt_timesheetDate_TextChanged(object sender, EventArgs e)
        {

        }

        public removeTimesheet(int hoursWorked, string date, string message)
        {
            _hoursWorked = hoursWorked;
            _date = date;
            _message = message;
        }
    }
}
