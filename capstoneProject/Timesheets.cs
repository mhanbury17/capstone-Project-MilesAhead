using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capstoneProject
{
    class Timesheets
    {
            private int _timesheetID;
            private string _timesheetDATE;
            private int _timesheetHOURS;
            private int _timesheetMINUTES;
            private int _timesheetTICKS;

            public int TimesheetID
            {
                get { return _timesheetID; }
                set { _timesheetID = value; }
            }

            public string TimesheetDate
            {
                get { return _timesheetDATE; }
                set { _timesheetDATE = value; }
            }

            public int TimesheetHours
            {
                get { return _timesheetHOURS; }
                set { _timesheetHOURS = value; }
            }

            public int TimesheetMinutes
            {
                get { return _timesheetMINUTES; }
                set { _timesheetMINUTES = value; }
            }

            public int TimesheetTicks
            {
                get { return _timesheetTICKS; }
                set { _timesheetTICKS = value; }
            }
    }
}
