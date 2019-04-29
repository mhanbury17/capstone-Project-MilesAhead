using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capstoneProject
{
    class addTimesheetData
    {
        #region PROPERTIES/FIELDS

        private int _hours;
        private int _minutes;
        private int _seconds;
        private string _date;
        private int _rmvTimesheetID;

        public int TimesheetID
        {
            get { return _rmvTimesheetID; }
            set { _rmvTimesheetID = value; }
        }


        public string TimesheetDate
        {
            get { return _date; }
            set { _date = value; }
        }

        public int Seconds
        {
            get { return _seconds; }
            set { _seconds = value; }
        }

        public int Minutes
        {
            get { return _minutes; }
            set { _minutes = value; }
        }

        public int Hours
        {
            get { return _hours; }
            set { _hours = value; }
        }

        public addTimesheetData(string date, int hours, int minutes, int seconds, int ID)
        {
            _date = date;
            _hours = hours;
            _minutes = minutes;
            _seconds = seconds;
            _rmvTimesheetID = ID;
            bool returnInfo = false;
            clockInformation sendTo = new clockInformation(date, hours, minutes, seconds, ID, returnInfo);
        }


        #endregion
    }
}
