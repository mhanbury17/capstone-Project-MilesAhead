namespace capstoneProject
{
    partial class clockInformation
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clock_in = new System.Windows.Forms.Button();
            this.btn_clock_out = new System.Windows.Forms.Button();
            this.btn_break = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_hoursWorkedToday = new System.Windows.Forms.Label();
            this.lbl_hoursWorkedThisWeek = new System.Windows.Forms.Label();
            this.btn_addTimesheet = new System.Windows.Forms.Button();
            this.txt_timesheets = new System.Windows.Forms.TextBox();
            this.lbl_clockTimer = new System.Windows.Forms.Label();
            this.btn_RemoveTimesheet = new System.Windows.Forms.Button();
            this.btn_done = new System.Windows.Forms.Button();
            this.tmr_clockStart = new System.Windows.Forms.Timer(this.components);
            this.removeTimesheet1 = new capstoneProject.removeTimesheet();
            this.addTimesheet1 = new capstoneProject.addTimesheet();
            this.btn_addToTimesheet = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Clock";
            // 
            // btn_clock_in
            // 
            this.btn_clock_in.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_clock_in.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clock_in.FlatAppearance.BorderSize = 0;
            this.btn_clock_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clock_in.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.btn_clock_in.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_clock_in.Location = new System.Drawing.Point(350, 115);
            this.btn_clock_in.Name = "btn_clock_in";
            this.btn_clock_in.Size = new System.Drawing.Size(150, 50);
            this.btn_clock_in.TabIndex = 1;
            this.btn_clock_in.Text = "Clock In";
            this.btn_clock_in.UseVisualStyleBackColor = false;
            this.btn_clock_in.Click += new System.EventHandler(this.Btn_clock_in_Click);
            // 
            // btn_clock_out
            // 
            this.btn_clock_out.BackColor = System.Drawing.Color.IndianRed;
            this.btn_clock_out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clock_out.FlatAppearance.BorderSize = 0;
            this.btn_clock_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clock_out.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.btn_clock_out.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_clock_out.Location = new System.Drawing.Point(650, 115);
            this.btn_clock_out.Name = "btn_clock_out";
            this.btn_clock_out.Size = new System.Drawing.Size(150, 50);
            this.btn_clock_out.TabIndex = 2;
            this.btn_clock_out.Text = "Clock Out";
            this.btn_clock_out.UseVisualStyleBackColor = false;
            this.btn_clock_out.Click += new System.EventHandler(this.Btn_clock_out_Click);
            // 
            // btn_break
            // 
            this.btn_break.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_break.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_break.FlatAppearance.BorderSize = 0;
            this.btn_break.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_break.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.btn_break.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_break.Location = new System.Drawing.Point(500, 115);
            this.btn_break.Name = "btn_break";
            this.btn_break.Size = new System.Drawing.Size(150, 50);
            this.btn_break.TabIndex = 3;
            this.btn_break.Text = "Start Break";
            this.btn_break.UseVisualStyleBackColor = false;
            this.btn_break.Click += new System.EventHandler(this.Btn_break_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "TOTAL HOURS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(14, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Today";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(14, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "This Week";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Location = new System.Drawing.Point(17, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 5);
            this.panel2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Timesheets";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label6.Location = new System.Drawing.Point(467, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 39);
            this.label6.TabIndex = 9;
            this.label6.Text = "Clocked Out";
            // 
            // lbl_hoursWorkedToday
            // 
            this.lbl_hoursWorkedToday.AutoSize = true;
            this.lbl_hoursWorkedToday.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_hoursWorkedToday.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_hoursWorkedToday.Location = new System.Drawing.Point(267, 108);
            this.lbl_hoursWorkedToday.Name = "lbl_hoursWorkedToday";
            this.lbl_hoursWorkedToday.Size = new System.Drawing.Size(72, 21);
            this.lbl_hoursWorkedToday.TabIndex = 10;
            this.lbl_hoursWorkedToday.Text = "00:00:00";
            this.lbl_hoursWorkedToday.Click += new System.EventHandler(this.Lbl_hoursWorkedToday_Click);
            // 
            // lbl_hoursWorkedThisWeek
            // 
            this.lbl_hoursWorkedThisWeek.AutoSize = true;
            this.lbl_hoursWorkedThisWeek.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_hoursWorkedThisWeek.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_hoursWorkedThisWeek.Location = new System.Drawing.Point(267, 129);
            this.lbl_hoursWorkedThisWeek.Name = "lbl_hoursWorkedThisWeek";
            this.lbl_hoursWorkedThisWeek.Size = new System.Drawing.Size(72, 21);
            this.lbl_hoursWorkedThisWeek.TabIndex = 11;
            this.lbl_hoursWorkedThisWeek.Text = "00:00:00";
            // 
            // btn_addTimesheet
            // 
            this.btn_addTimesheet.BackColor = System.Drawing.Color.Transparent;
            this.btn_addTimesheet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addTimesheet.FlatAppearance.BorderSize = 0;
            this.btn_addTimesheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addTimesheet.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_addTimesheet.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn_addTimesheet.Location = new System.Drawing.Point(540, 185);
            this.btn_addTimesheet.Name = "btn_addTimesheet";
            this.btn_addTimesheet.Size = new System.Drawing.Size(150, 44);
            this.btn_addTimesheet.TabIndex = 12;
            this.btn_addTimesheet.Text = "+ Timesheet";
            this.btn_addTimesheet.UseVisualStyleBackColor = false;
            this.btn_addTimesheet.Click += new System.EventHandler(this.Btn_addTimesheet_Click);
            // 
            // txt_timesheets
            // 
            this.txt_timesheets.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_timesheets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_timesheets.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_timesheets.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_timesheets.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_timesheets.Location = new System.Drawing.Point(18, 234);
            this.txt_timesheets.Multiline = true;
            this.txt_timesheets.Name = "txt_timesheets";
            this.txt_timesheets.ReadOnly = true;
            this.txt_timesheets.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_timesheets.Size = new System.Drawing.Size(783, 380);
            this.txt_timesheets.TabIndex = 13;
            this.txt_timesheets.TextChanged += new System.EventHandler(this.Txt_timesheets_TextChanged);
            // 
            // lbl_clockTimer
            // 
            this.lbl_clockTimer.AutoSize = true;
            this.lbl_clockTimer.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lbl_clockTimer.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_clockTimer.Location = new System.Drawing.Point(536, 70);
            this.lbl_clockTimer.Name = "lbl_clockTimer";
            this.lbl_clockTimer.Size = new System.Drawing.Size(86, 22);
            this.lbl_clockTimer.TabIndex = 14;
            this.lbl_clockTimer.Text = "00:00:00";
            // 
            // btn_RemoveTimesheet
            // 
            this.btn_RemoveTimesheet.BackColor = System.Drawing.Color.Transparent;
            this.btn_RemoveTimesheet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RemoveTimesheet.FlatAppearance.BorderSize = 0;
            this.btn_RemoveTimesheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveTimesheet.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_RemoveTimesheet.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn_RemoveTimesheet.Location = new System.Drawing.Point(663, 184);
            this.btn_RemoveTimesheet.Name = "btn_RemoveTimesheet";
            this.btn_RemoveTimesheet.Size = new System.Drawing.Size(150, 44);
            this.btn_RemoveTimesheet.TabIndex = 15;
            this.btn_RemoveTimesheet.Text = "- Timesheet";
            this.btn_RemoveTimesheet.UseVisualStyleBackColor = false;
            this.btn_RemoveTimesheet.Click += new System.EventHandler(this.Btn_RemoveTimesheet_Click);
            // 
            // btn_done
            // 
            this.btn_done.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_done.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_done.FlatAppearance.BorderSize = 0;
            this.btn_done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_done.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btn_done.Location = new System.Drawing.Point(645, 115);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(134, 38);
            this.btn_done.TabIndex = 20;
            this.btn_done.Text = "Done";
            this.btn_done.UseVisualStyleBackColor = false;
            this.btn_done.Click += new System.EventHandler(this.Btn_done_Click);
            // 
            // tmr_clockStart
            // 
            this.tmr_clockStart.Interval = 1000;
            this.tmr_clockStart.Tick += new System.EventHandler(this.Tmr_clockStart_Tick);
            // 
            // removeTimesheet1
            // 
            this.removeTimesheet1.Location = new System.Drawing.Point(0, 0);
            this.removeTimesheet1.Name = "removeTimesheet1";
            this.removeTimesheet1.Size = new System.Drawing.Size(816, 180);
            this.removeTimesheet1.TabIndex = 17;
            // 
            // addTimesheet1
            // 
            this.addTimesheet1.Location = new System.Drawing.Point(0, 0);
            this.addTimesheet1.Name = "addTimesheet1";
            this.addTimesheet1.Size = new System.Drawing.Size(816, 180);
            this.addTimesheet1.TabIndex = 23;
            // 
            // btn_addToTimesheet
            // 
            this.btn_addToTimesheet.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_addToTimesheet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addToTimesheet.FlatAppearance.BorderSize = 0;
            this.btn_addToTimesheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addToTimesheet.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btn_addToTimesheet.Location = new System.Drawing.Point(645, 70);
            this.btn_addToTimesheet.Name = "btn_addToTimesheet";
            this.btn_addToTimesheet.Size = new System.Drawing.Size(134, 38);
            this.btn_addToTimesheet.TabIndex = 22;
            this.btn_addToTimesheet.Text = "Add";
            this.btn_addToTimesheet.UseVisualStyleBackColor = false;
            this.btn_addToTimesheet.Click += new System.EventHandler(this.Btn_addToTimesheet_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.IndianRed;
            this.btn_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btn_remove.Location = new System.Drawing.Point(645, 25);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(134, 38);
            this.btn_remove.TabIndex = 24;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.Btn_remove_Click);
            // 
            // clockInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_addToTimesheet);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.removeTimesheet1);
            this.Controls.Add(this.addTimesheet1);
            this.Controls.Add(this.btn_RemoveTimesheet);
            this.Controls.Add(this.lbl_clockTimer);
            this.Controls.Add(this.txt_timesheets);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_addTimesheet);
            this.Controls.Add(this.lbl_hoursWorkedThisWeek);
            this.Controls.Add(this.lbl_hoursWorkedToday);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_break);
            this.Controls.Add(this.btn_clock_out);
            this.Controls.Add(this.btn_clock_in);
            this.Controls.Add(this.label1);
            this.Name = "clockInformation";
            this.Size = new System.Drawing.Size(816, 632);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clock_in;
        private System.Windows.Forms.Button btn_clock_out;
        private System.Windows.Forms.Button btn_break;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_hoursWorkedToday;
        private System.Windows.Forms.Label lbl_hoursWorkedThisWeek;
        private System.Windows.Forms.Button btn_addTimesheet;
        private System.Windows.Forms.Label lbl_clockTimer;
        private System.Windows.Forms.Button btn_RemoveTimesheet;
        private addTimesheet addTimesheet1;
        private removeTimesheet removeTimesheet1;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Timer tmr_clockStart;
        public System.Windows.Forms.TextBox txt_timesheets;
        private System.Windows.Forms.Button btn_addToTimesheet;
        private System.Windows.Forms.Button btn_remove;
    }
}
