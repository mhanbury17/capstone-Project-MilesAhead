using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capstoneProject
{
    class clockInfoTOremoveTimesheet
    {
        private string label;
        private int _hoursWorked;
        private string _date;

        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }


        public int HoursWorked
        {
            get { return _hoursWorked; }
            set { _hoursWorked = value; }
        }

        public string LabelMessage
        {
            get { return label; }
            set { label = value; }
        }

        public clockInfoTOremoveTimesheet(int hoursWorked, string date, string message)
        {
            _hoursWorked = hoursWorked;
            _date = date;
            label = message;
            removeTimesheet sendTo = new removeTimesheet(hoursWorked, date, message);
        }
    }
}
