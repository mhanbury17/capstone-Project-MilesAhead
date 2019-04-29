namespace capstoneProject
{
    partial class schedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(schedule));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_addTask = new System.Windows.Forms.Button();
            this.addTaskPrompt1 = new capstoneProject.addTaskPrompt();
            this.tasklistItem1 = new capstoneProject.tasklistItem();
            this.btn_close_x = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Schedule";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label2.Location = new System.Drawing.Point(531, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tasks";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.tasklistItem1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(536, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(280, 589);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btn_addTask
            // 
            this.btn_addTask.BackColor = System.Drawing.Color.Transparent;
            this.btn_addTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_addTask.FlatAppearance.BorderSize = 0;
            this.btn_addTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addTask.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btn_addTask.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_addTask.Location = new System.Drawing.Point(738, 15);
            this.btn_addTask.Name = "btn_addTask";
            this.btn_addTask.Size = new System.Drawing.Size(75, 27);
            this.btn_addTask.TabIndex = 4;
            this.btn_addTask.Text = "+ Task";
            this.btn_addTask.UseVisualStyleBackColor = false;
            this.btn_addTask.Click += new System.EventHandler(this.Btn_addTask_Click);
            // 
            // addTaskPrompt1
            // 
            this.addTaskPrompt1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addTaskPrompt1.Location = new System.Drawing.Point(150, 150);
            this.addTaskPrompt1.Name = "addTaskPrompt1";
            this.addTaskPrompt1.Size = new System.Drawing.Size(500, 250);
            this.addTaskPrompt1.TabIndex = 5;
            // 
            // tasklistItem1
            // 
            this.tasklistItem1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tasklistItem1.Description = "";
            this.tasklistItem1.Location = new System.Drawing.Point(3, 3);
            this.tasklistItem1.Name = "tasklistItem1";
            this.tasklistItem1.Size = new System.Drawing.Size(265, 75);
            this.tasklistItem1.TabIndex = 0;
            this.tasklistItem1.Title = null;
            // 
            // btn_close_x
            // 
            this.btn_close_x.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_close_x.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close_x.BackgroundImage")));
            this.btn_close_x.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close_x.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close_x.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close_x.FlatAppearance.BorderSize = 0;
            this.btn_close_x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close_x.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close_x.Location = new System.Drawing.Point(630, 155);
            this.btn_close_x.Name = "btn_close_x";
            this.btn_close_x.Size = new System.Drawing.Size(15, 15);
            this.btn_close_x.TabIndex = 24;
            this.btn_close_x.UseVisualStyleBackColor = false;
            this.btn_close_x.Click += new System.EventHandler(this.Btn_close_x_Click);
            // 
            // schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_close_x);
            this.Controls.Add(this.addTaskPrompt1);
            this.Controls.Add(this.btn_addTask);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "schedule";
            this.Size = new System.Drawing.Size(816, 632);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private tasklistItem tasklistItem1;
        private System.Windows.Forms.Button btn_addTask;
        private addTaskPrompt addTaskPrompt1;
        private System.Windows.Forms.Button btn_close_x;
    }
}
