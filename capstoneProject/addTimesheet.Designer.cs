namespace capstoneProject
{
    partial class addTimesheet
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_clockIn = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_clock_out = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_totalBreak = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_hoursTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "+ Timesheet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(20, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Clock In";
            // 
            // dtp_clockIn
            // 
            this.dtp_clockIn.CalendarFont = new System.Drawing.Font("Century Gothic", 16F);
            this.dtp_clockIn.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtp_clockIn.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtp_clockIn.CustomFormat = "hh:mm:ss:tt";
            this.dtp_clockIn.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.dtp_clockIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_clockIn.Location = new System.Drawing.Point(126, 65);
            this.dtp_clockIn.Name = "dtp_clockIn";
            this.dtp_clockIn.Size = new System.Drawing.Size(154, 34);
            this.dtp_clockIn.TabIndex = 4;
            this.dtp_clockIn.ValueChanged += new System.EventHandler(this.Dtp_clockIn_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(286, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Clock Out";
            // 
            // dtp_clock_out
            // 
            this.dtp_clock_out.CalendarFont = new System.Drawing.Font("Century Gothic", 16F);
            this.dtp_clock_out.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtp_clock_out.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtp_clock_out.CustomFormat = "hh:mm:ss:tt";
            this.dtp_clock_out.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.dtp_clock_out.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_clock_out.Location = new System.Drawing.Point(413, 65);
            this.dtp_clock_out.Name = "dtp_clock_out";
            this.dtp_clock_out.Size = new System.Drawing.Size(154, 34);
            this.dtp_clock_out.TabIndex = 6;
            this.dtp_clock_out.ValueChanged += new System.EventHandler(this.Dtp_clock_out_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(20, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Break Total (Min)";
            // 
            // txt_totalBreak
            // 
            this.txt_totalBreak.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.txt_totalBreak.Location = new System.Drawing.Point(215, 115);
            this.txt_totalBreak.Name = "txt_totalBreak";
            this.txt_totalBreak.Size = new System.Drawing.Size(140, 34);
            this.txt_totalBreak.TabIndex = 8;
            this.txt_totalBreak.TextChanged += new System.EventHandler(this.Txt_totalBreak_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(361, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hours";
            // 
            // txt_hoursTotal
            // 
            this.txt_hoursTotal.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.txt_hoursTotal.Location = new System.Drawing.Point(437, 115);
            this.txt_hoursTotal.Name = "txt_hoursTotal";
            this.txt_hoursTotal.ReadOnly = true;
            this.txt_hoursTotal.Size = new System.Drawing.Size(100, 34);
            this.txt_hoursTotal.TabIndex = 10;
            this.txt_hoursTotal.TextChanged += new System.EventHandler(this.Txt_hoursTotal_TextChanged);
            // 
            // addTimesheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_hoursTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_totalBreak);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_clock_out);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_clockIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "addTimesheet";
            this.Size = new System.Drawing.Size(816, 180);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_clockIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_clock_out;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_totalBreak;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_hoursTotal;
    }
}
