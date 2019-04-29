namespace capstoneProject
{
    partial class removeTimesheet
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components =  null;

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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_timesheetID = new System.Windows.Forms.TextBox();
            this.lbl_timesheetValidationMessage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hoursWorked = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_timesheetDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "- Timesheet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Timesheet ID";
            // 
            // txt_timesheetID
            // 
            this.txt_timesheetID.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.txt_timesheetID.Location = new System.Drawing.Point(172, 54);
            this.txt_timesheetID.Name = "txt_timesheetID";
            this.txt_timesheetID.Size = new System.Drawing.Size(134, 34);
            this.txt_timesheetID.TabIndex = 4;
            this.txt_timesheetID.TextChanged += new System.EventHandler(this.Txt_timesheetID_TextChanged);
            // 
            // lbl_timesheetValidationMessage
            // 
            this.lbl_timesheetValidationMessage.AutoSize = true;
            this.lbl_timesheetValidationMessage.BackColor = System.Drawing.Color.Transparent;
            this.lbl_timesheetValidationMessage.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timesheetValidationMessage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_timesheetValidationMessage.Location = new System.Drawing.Point(368, 63);
            this.lbl_timesheetValidationMessage.Name = "lbl_timesheetValidationMessage";
            this.lbl_timesheetValidationMessage.Size = new System.Drawing.Size(198, 24);
            this.lbl_timesheetValidationMessage.TabIndex = 5;
            this.lbl_timesheetValidationMessage.Text = "Enter Timesheet ID";
            this.lbl_timesheetValidationMessage.Click += new System.EventHandler(this.Lbl_timesheetValidationMessage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(260, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hours Worked";
            // 
            // txt_hoursWorked
            // 
            this.txt_hoursWorked.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.txt_hoursWorked.Location = new System.Drawing.Point(426, 113);
            this.txt_hoursWorked.Name = "txt_hoursWorked";
            this.txt_hoursWorked.ReadOnly = true;
            this.txt_hoursWorked.Size = new System.Drawing.Size(140, 34);
            this.txt_hoursWorked.TabIndex = 9;
            this.txt_hoursWorked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_hoursWorked.TextChanged += new System.EventHandler(this.Txt_hoursWorked_TextChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btn_clear.Location = new System.Drawing.Point(645, 70);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(134, 38);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(17, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // txt_timesheetDate
            // 
            this.txt_timesheetDate.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.txt_timesheetDate.Location = new System.Drawing.Point(98, 113);
            this.txt_timesheetDate.Name = "txt_timesheetDate";
            this.txt_timesheetDate.ReadOnly = true;
            this.txt_timesheetDate.Size = new System.Drawing.Size(140, 34);
            this.txt_timesheetDate.TabIndex = 12;
            this.txt_timesheetDate.TextChanged += new System.EventHandler(this.Txt_timesheetDate_TextChanged);
            // 
            // removeTimesheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_timesheetDate);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_hoursWorked);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_timesheetValidationMessage);
            this.Controls.Add(this.txt_timesheetID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "removeTimesheet";
            this.Size = new System.Drawing.Size(816, 180);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_timesheetID;
        private System.Windows.Forms.Label lbl_timesheetValidationMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hoursWorked;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_timesheetDate;
    }
}
