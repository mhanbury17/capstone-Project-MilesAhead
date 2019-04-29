namespace capstoneProject
{
    partial class tasklistItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tasklistItem));
            this.btn_deleteTask = new System.Windows.Forms.PictureBox();
            this.lbl_taskTitle = new System.Windows.Forms.Label();
            this.lbl_taskDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_deleteTask)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_deleteTask
            // 
            this.btn_deleteTask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_deleteTask.BackgroundImage")));
            this.btn_deleteTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_deleteTask.Location = new System.Drawing.Point(15, 25);
            this.btn_deleteTask.Name = "btn_deleteTask";
            this.btn_deleteTask.Size = new System.Drawing.Size(25, 25);
            this.btn_deleteTask.TabIndex = 0;
            this.btn_deleteTask.TabStop = false;
            this.btn_deleteTask.Click += new System.EventHandler(this.Btn_deleteTask_Click);
            // 
            // lbl_taskTitle
            // 
            this.lbl_taskTitle.AutoSize = true;
            this.lbl_taskTitle.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lbl_taskTitle.Location = new System.Drawing.Point(50, 15);
            this.lbl_taskTitle.Name = "lbl_taskTitle";
            this.lbl_taskTitle.Size = new System.Drawing.Size(48, 22);
            this.lbl_taskTitle.TabIndex = 1;
            this.lbl_taskTitle.Text = "Task";
            this.lbl_taskTitle.Click += new System.EventHandler(this.Lbl_taskTitle_Click);
            // 
            // lbl_taskDescription
            // 
            this.lbl_taskDescription.AutoSize = true;
            this.lbl_taskDescription.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lbl_taskDescription.Location = new System.Drawing.Point(50, 40);
            this.lbl_taskDescription.Name = "lbl_taskDescription";
            this.lbl_taskDescription.Size = new System.Drawing.Size(85, 19);
            this.lbl_taskDescription.TabIndex = 2;
            this.lbl_taskDescription.Text = "Description";
            this.lbl_taskDescription.Click += new System.EventHandler(this.Lbl_taskDescription_Click);
            // 
            // tasklistItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.lbl_taskDescription);
            this.Controls.Add(this.lbl_taskTitle);
            this.Controls.Add(this.btn_deleteTask);
            this.Name = "tasklistItem";
            this.Size = new System.Drawing.Size(265, 75);
            ((System.ComponentModel.ISupportInitialize)(this.btn_deleteTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_deleteTask;
        private System.Windows.Forms.Label lbl_taskTitle;
        private System.Windows.Forms.Label lbl_taskDescription;
    }
}
