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
    public partial class clockInformation : UserControl
    {
        public clockInformation()
        {
            InitializeComponent();
            //
            // hide hours worked this week / under-developed
            //
            label4.Hide();
            lbl_hoursWorkedThisWeek.Hide();

            UpdateRecap();

            Timesheets[] timesheets = new Timesheets[1];
            string TIMESHEET_PATH = @"..\..\timesheet_DATA\timesheet.txt";
            bool goDisplay = true;
            goDisplay = LoadTimesheet(ref timesheets, TIMESHEET_PATH);
            if (goDisplay)
            {
                DisplayTimesheet(timesheets, txt_timesheets);
            }
            goHideAll();
        }

        private bool LoadTimesheet(ref Timesheets[] timesheets, string TIMESHEET_PATH)
        {
            bool goDisplay = true;
            StreamReader reader = new StreamReader(TIMESHEET_PATH);
            int size = int.Parse(reader.ReadLine().First().ToString());
            if (size == 0)
            {
                reader.Close();
                goDisplay = false;
                txt_timesheets.Clear();
            }
            else
            {
                timesheets = new Timesheets[size];
                for (int i = 0; i < timesheets.Length; i++)
                {
                    timesheets[i] = new Timesheets();
                    timesheets[i].TimesheetID = int.Parse(reader.ReadLine());
                    timesheets[i].TimesheetDate = reader.ReadLine();
                    timesheets[i].TimesheetHours = int.Parse(reader.ReadLine());
                    timesheets[i].TimesheetMinutes = int.Parse(reader.ReadLine());
                    timesheets[i].TimesheetTicks = int.Parse(reader.ReadLine());
                }
                reader.Close();
            }

            return goDisplay;
            
        }

        private void Btn_clock_in_Click(object sender, EventArgs e)
        {
            tmr_clockStart.Start();
        }

        private int hoursT, minutesT, ticksT;

        private void Btn_clock_out_Click(object sender, EventArgs e)
        {
            if (tmr_clockStart.Enabled)
            {
                tmr_clockStart.Stop();

                #region HOURS TODAY DISPLAY

            lbl_clockTimer.Text = "00:00:00";
            hoursT = hoursT + hrs;
            minutesT = minutesT + mins;
            ticksT = ticksT + _ticks;
            string hrsTST, minsTST, ticksTST;
            if (ticksT>=60)
            {
                minutesT++;
                ticksT = ticksT - 60;
            }
            if (minutesT>=60)
            {
                hoursT++;
                minutesT = minutesT - 60;

            }
            if (hoursT < 10)
            {
                hrsTST = $"0{hoursT}";
            }
            else
            {
                hrsTST = hoursT.ToString();
            }
            if (minutesT < 10)
            {
                minsTST = $"0{minutesT}";
            }
            else
            {
                minsTST = minutesT.ToString();
            }
            if (ticksT < 10)
            {
                ticksTST = $"0{ticksT}";
            }
            else
            {
                ticksTST = ticksT.ToString();
            }

            

            #endregion
                    
                #region SAVE TO FILE.IO

            Timesheets[] timesheets = new Timesheets[1];
            string TIMESHEET_PATH = @"..\..\timesheet_DATA\timesheet.txt";

            bool Added = false;
            int size;

            size = LoadData(TIMESHEET_PATH, ref timesheets, hrs, mins, _ticks, Added);

            if (size>0)
            {
                AddTimesheet(ref timesheets, TIMESHEET_PATH, hrs, mins, _ticks, Added, size);
            }
            

            DisplayTimesheet(timesheets, txt_timesheets);

            #endregion

                hrs = 0;
                mins = 0;
                _ticks = 0;
            }
        }

        private void UpdateRecap()
        {
            UpdateHoursWorkedToday();
            UpdateHoursWorkedThisWeek();
        }

        private void UpdateHoursWorkedThisWeek()
        {
            //var file = File.ReadAllLines(@"..\..\timesheet_DATA\timesheet.txt");
            //List<string> timesheetsList = new List<string>(file);

            //
            // 1. get day of week
            // 2. based on day of week subtract date of month to get first day of week
            // 3. follow exp.
            //



        }

        private void UpdateHoursWorkedToday()
        {
            var file = File.ReadAllLines(@"..\..\timesheet_DATA\timesheet.txt");
            List<string> timesheetsList = new List<string>(file);

            int idx=0, hh=0, mm=0, ss=0;
            string _hh, _mm, _ss;

            if (timesheetsList.Contains(DateTime.Today.ToShortDateString()))
            {
                foreach (string item in timesheetsList)
                {
                    
                    if (item  == DateTime.Today.ToShortDateString())
                    {
                        hh = hh + int.Parse(timesheetsList.ElementAt(idx+1));
                        mm = mm + int.Parse(timesheetsList.ElementAt(idx+2));
                        ss = ss + int.Parse(timesheetsList.ElementAt(idx+3));
                    }
                    idx++;

                }
                if (hh<10)
                {
                    _hh = $"0{hh}";
                }
                else
                {
                    _hh = hh.ToString();
                }
                if (mm<10)
                {
                    _mm = $"0{mm}";
                }
                else
                {
                    _mm = mm.ToString();
                }
                if (ss<10)
                {
                    _ss = $"0{ss}";
                }
                else
                {
                    _ss = ss.ToString();
                }
                lbl_hoursWorkedToday.Text = $"{_hh}:{_mm}:{_ss}";
            }
            else if (timesheetsList.Count()==1)
            {
                lbl_hoursWorkedToday.Text = $"00:00:00";
            }
        }

        public static int addedCount;

        private static int LoadData(string TIMESHEET_PATH, ref Timesheets[] timesheets, int hrs, int mins, int _ticks, bool adding)
        {
            StreamReader reader = new StreamReader(TIMESHEET_PATH);
            int size = int.Parse(reader.ReadLine());
            if (size==0)
            {
                // CHECKS THAT NO DATA HAS BEEN ENTERED YET
                timesheets = new Timesheets[1];
                reader.Close();
                adding = true;
                AddTimesheet(ref timesheets, TIMESHEET_PATH, hrs, mins, _ticks, adding, size);
            }
            else
            {
                timesheets = new Timesheets[size];
                for (int i = 0; i < timesheets.Length; i++)
                {
                    timesheets[i] = new Timesheets();
                    timesheets[i].TimesheetID = int.Parse(reader.ReadLine());
                    timesheets[i].TimesheetDate = reader.ReadLine();
                    timesheets[i].TimesheetHours = int.Parse(reader.ReadLine());
                    timesheets[i].TimesheetMinutes = int.Parse(reader.ReadLine());
                    timesheets[i].TimesheetTicks = int.Parse(reader.ReadLine());
                }
                reader.Close();
            }

            if (adding)
            {
                adding = false;
            }

            return size;
        }

        private static void DisplayTimesheet(Timesheets[] timesheets, TextBox txt_timesheets)
        {
            txt_timesheets.Clear();
            for (int i = 0; i < timesheets.Length; i++)
            {
                txt_timesheets.AppendText($"ID: {timesheets[i].TimesheetID} DATE: {timesheets[i].TimesheetDate} | TIME WORKED | HOURS: {timesheets[i].TimesheetHours} |" +
                    $" MINUTES: {timesheets[i].TimesheetMinutes} | SECONDS: {timesheets[i].TimesheetTicks}"+Environment.NewLine);
                
            }
        }

        public static int sheetCounter;
        private static void AddTimesheet(ref Timesheets[] timesheets, string TIMESHEET_PATH, int hrs, int mins, int _ticks, bool timesheetAdded, int size)
        {
            var file = File.ReadAllLines(TIMESHEET_PATH);
            List<string> timesheetsList = new List<string>(file);
            StreamWriter writer = new StreamWriter(TIMESHEET_PATH);
            if (!timesheetAdded)
            {
                writer.WriteLine(timesheets.Length + 1);
            }
            else
            {
                writer.WriteLine(timesheets.Length);
            }
            sheetCounter++;
            // GET DATA
            Timesheets temp = new Timesheets();
            
            if (size>0)
            {
                temp.TimesheetID = int.Parse(timesheetsList.ElementAt(1)) + 1;
            }
            else
            {
                temp.TimesheetID = 100;
            }
            temp.TimesheetDate = (DateTime.Today).ToShortDateString();
            temp.TimesheetHours = hrs;
            temp.TimesheetMinutes = mins;
            temp.TimesheetTicks = _ticks;

            // WRITE NEW DATA TO FILE
            writer.WriteLine(temp.TimesheetID);
            writer.WriteLine(temp.TimesheetDate);
            writer.WriteLine(temp.TimesheetHours);
            writer.WriteLine(temp.TimesheetMinutes);
            writer.WriteLine(temp.TimesheetTicks);

            // ADD OLD TIMESHEETS BACK
            if (!timesheetAdded)
            {
                for (int i = 0; i < timesheets.Length; i++)
                {
                    writer.WriteLine(timesheets[i].TimesheetID);
                    writer.WriteLine(timesheets[i].TimesheetDate);
                    writer.WriteLine(timesheets[i].TimesheetHours);
                    writer.WriteLine(timesheets[i].TimesheetMinutes);
                    writer.WriteLine(timesheets[i].TimesheetTicks);
                }
            }

            writer.Close();

            //UPDATE ARRAY
            LoadData(TIMESHEET_PATH, ref timesheets, hrs, mins, _ticks, timesheetAdded);
        }

        private void Btn_break_Click(object sender, EventArgs e)
        {
            if (btn_break.Text=="Start Break")
            {
                tmr_clockStart.Stop();
                btn_break.Text = "End Break";
            }
            else
            {
                btn_break.Text = "Start Break";
                tmr_clockStart.Start();
            }
        }

        private void Lbl_hoursWorkedToday_Click(object sender, EventArgs e)
        {

        }

        private void Txt_timesheets_TextChanged(object sender, EventArgs e)
        {
            UpdateRecap();
        }

        private void Btn_RemoveTimesheet_Click(object sender, EventArgs e)
        {
            goHideAll();
            removeTimesheet1.Show();
            removeTimesheet1.BringToFront();
            btn_remove.Show();
            btn_remove.BringToFront();
            showDoneBtn();
        }

        private void Btn_addTimesheet_Click(object sender, EventArgs e)
        {
            goHideAll();
            addTimesheet1.Show();
            addTimesheet1.BringToFront();
            btn_addToTimesheet.Show();
            btn_addToTimesheet.BringToFront();
            showDoneBtn();
        }

        private void showDoneBtn()
        {
            btn_done.Show();
            btn_done.BringToFront();
        }

        private void goHideAll()
        {
            addTimesheet1.Hide();
            removeTimesheet1.Hide();
            btn_done.Hide();
            btn_addToTimesheet.Hide();
            btn_remove.Hide();
        }

        private void Btn_done_Click(object sender, EventArgs e)
        {
            goHideAll();
        }

        public static int _hours, _minutes, _seconds, _IDtoRemove;
        public static string _date;


        private void SearchByID(int ID)
        {
            string message = "Timesheet found", dateOfTimesheet;
            int hoursWorked;

            Timesheets[] timesheets = new Timesheets[1];
            string TIMESHEET_PATH = @"..\..\timesheet_DATA\timesheet.txt";

            //check for ID existance
            message = LoadDataForRemove(TIMESHEET_PATH, ref timesheets, message);

            #region CheckForID

            var file = File.ReadAllLines(TIMESHEET_PATH);
            List<string> timesheetsList = new List<string>(file);
            if (!timesheetsList.Contains(ID.ToString())||ID<100)
            {
                hoursWorked = 0;
                dateOfTimesheet = "N/A";
                message = "Timesheet not found";
            }
            else
            {
                int pos = timesheetsList.IndexOf(ID.ToString());
                hoursWorked = int.Parse(timesheetsList.ElementAt(pos+2));
                dateOfTimesheet = timesheetsList.ElementAt(pos+1);
            }

            #endregion

            


            clockInfoTOremoveTimesheet sendBack = new clockInfoTOremoveTimesheet(hoursWorked, dateOfTimesheet, message);

        }


        private int _ticks,hrs,mins;
        private void Tmr_clockStart_Tick(object sender, EventArgs e)
        {
            // CREATE TIMER
            _ticks++;
            if (_ticks==60)
            {
                _ticks = 0;
                mins++;
            }
            if (mins == 60)
            {
                mins = 0;
                hrs++;
            }

            // DISPLAY TIMER
            string hrsString,minsString,ticksString;
            if (hrs<10)
            {
                hrsString = $"0{hrs}";
            }
            else
            {
                hrsString = hrs.ToString();
            }
            if (mins<10)
            {
                minsString = $"0{mins}";
            }
            else
            {
                minsString = mins.ToString();
            }
            if (_ticks<10)
            {
                ticksString = $"0{_ticks}";
            }
            else
            {
                ticksString = _ticks.ToString();
            }

            lbl_clockTimer.Text = $"{hrsString}:{minsString}:{ticksString}";
        }

        public static int sheetCounter2;

        public clockInformation(string date, int hours, int minutes, int seconds, int ID, bool returnInfo)
        {
            _date = date;
            _hours = hours;
            _minutes = minutes;
            _seconds = seconds;
            _IDtoRemove = ID;
            if (returnInfo)
            {
                SearchByID(ID);
            }
        }

        private static bool AddTimesheetFromTimesheetInfo(ref Timesheets[] timesheets, string TIMESHEET_PATH, bool timesheetAdded, int hours, int minutes, int seconds, string timesheetDate, int size)
        {
            bool goDisplay;
            if (timesheetDate != null&&hours>=0&&minutes>=0&&seconds>=0)
            {
                var file = File.ReadAllLines(TIMESHEET_PATH);
                List<string> timesheetsList = new List<string>(file);

                StreamWriter writer = new StreamWriter(TIMESHEET_PATH);
                if (!timesheetAdded)
                {
                    writer.WriteLine(timesheets.Length + 1);
                }
                else
                {
                    writer.WriteLine(timesheets.Length);
                }
                // GET DATA
                Timesheets temp = new Timesheets();

                if (size>0)
                {
                    temp.TimesheetID = int.Parse(timesheetsList.ElementAt(1))+1;
                }
                else
                {
                    temp.TimesheetID = 100;
                }
                temp.TimesheetDate = timesheetDate;
                temp.TimesheetHours = hours;
                temp.TimesheetMinutes = minutes;
                temp.TimesheetTicks = seconds;

                // WRITE NEW DATA TO FILE
                writer.WriteLine(temp.TimesheetID);
                writer.WriteLine(temp.TimesheetDate);
                writer.WriteLine(temp.TimesheetHours);
                writer.WriteLine(temp.TimesheetMinutes);
                writer.WriteLine(temp.TimesheetTicks);

                // ADD OLD TIMESHEETS BACK
                if (!timesheetAdded)
                {
                    for (int i = 0; i < timesheets.Length; i++)
                    {
                        writer.WriteLine(timesheets[i].TimesheetID);
                        writer.WriteLine(timesheets[i].TimesheetDate);
                        writer.WriteLine(timesheets[i].TimesheetHours);
                        writer.WriteLine(timesheets[i].TimesheetMinutes);
                        writer.WriteLine(timesheets[i].TimesheetTicks);
                    }
                }

                writer.Close();

                //UPDATE ARRAY
                LoadData(TIMESHEET_PATH, ref timesheets, hours, minutes, seconds, timesheetAdded);
                goDisplay = true;
            }
            else
            {
                goDisplay = false;
            }
            return goDisplay;
        }

        private void Btn_addToTimesheet_Click(object sender, EventArgs e)
        {
            #region SAVE TO FILE.IO

            Timesheets[] timesheets = new Timesheets[1];
            string TIMESHEET_PATH = @"..\..\timesheet_DATA\timesheet.txt";

            bool Added = false, goDisplay = true;
            int size;

            size = LoadData(TIMESHEET_PATH, ref timesheets, _hours, _minutes, _seconds, Added);

            if (size > 0)
            {
                goDisplay = AddTimesheetFromTimesheetInfo(ref timesheets, TIMESHEET_PATH, Added, _hours, _minutes, _seconds, _date, size);
            }
            if (goDisplay)
            {
                DisplayTimesheet(timesheets, txt_timesheets);
            }

            #endregion
        }

        private void Btn_remove_Click(object sender, EventArgs e)
        {
            Timesheets[] timesheets = new Timesheets[1];
            string TIMESHEET_PATH = @"..\..\timesheet_DATA\timesheet.txt";

            bool canRemove;

            canRemove = LoadTimesheet(ref timesheets, TIMESHEET_PATH);
            if (canRemove)
            {
                RemoveByID(timesheets, TIMESHEET_PATH);
            }
            UpdateRecap();
        }

        private void RemoveByID(Timesheets[] timesheets, string TIMESHEET_PATH)
        {
            //array is loaded / convert array to list

            var file = File.ReadAllLines(TIMESHEET_PATH);
            List<string> timesheetsList = new List<string>(file);
            

            //
            // CONVERT ARRAY TO STRING IN FOREACH THEN ADD TO LIST IN FOR LOOP
            //

            // remove item from list
            int _REMOVE, ELEMENT_ID;

            //
            // REMOVE REQUESTED ITEM
            //
            if (_IDtoRemove > 99)
            {
                ELEMENT_ID = timesheetsList.IndexOf(_IDtoRemove.ToString());

                _REMOVE = ELEMENT_ID - 1;
                if (ELEMENT_ID >= 0)
                {
                    try
                    {
                        timesheetsList.RemoveAt(0);
                        timesheetsList.Remove(_IDtoRemove.ToString());
                        timesheetsList.RemoveAt(_REMOVE);
                        timesheetsList.RemoveAt(_REMOVE);
                        timesheetsList.RemoveAt(_REMOVE);
                        timesheetsList.RemoveAt(_REMOVE);

                        // 
                        // FIRST TRY JUST WRITING ARRAY TO FILE AND SEE IF IT WORKS
                        //
                        StreamWriter writer = new StreamWriter(TIMESHEET_PATH);
                        writer.WriteLine(timesheets.Length - 1);
                        foreach (string item in timesheetsList)
                        {
                            writer.WriteLine(item);
                        }
                        writer.Close();

                        bool goDisplay;
                        goDisplay = LoadTimesheet(ref timesheets, TIMESHEET_PATH);
                        if (goDisplay)
                        {
                            DisplayTimesheet(timesheets, txt_timesheets);
                        }

                        
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("Timesheet does not exist. Cannot remove.");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Timesheet does not exist. Cannot remove.");
            }

            
        }

        private static string LoadDataForRemove(string TIMESHEET_PATH, ref Timesheets[] timesheets, string message)
        {
            StreamReader reader = new StreamReader(TIMESHEET_PATH);
            int size = int.Parse(reader.ReadLine());
            if (size == 0)
            {
                // CHECKS THAT NO DATA HAS BEEN ENTERED YET
                message = "No Timesheets found in 'timesheet.txt'";
            }
            else
            {
                timesheets = new Timesheets[size];
                for (int i = 0; i < timesheets.Length; i++)
                {
                    timesheets[i] = new Timesheets();
                    timesheets[i].TimesheetID = int.Parse(reader.ReadLine());
                    timesheets[i].TimesheetDate = reader.ReadLine();
                    timesheets[i].TimesheetHours = int.Parse(reader.ReadLine());
                    timesheets[i].TimesheetMinutes = int.Parse(reader.ReadLine());
                    timesheets[i].TimesheetTicks = int.Parse(reader.ReadLine());
                }
                reader.Close();
            }

            return message;
        }
    }
}
