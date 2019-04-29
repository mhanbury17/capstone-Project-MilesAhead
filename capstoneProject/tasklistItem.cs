using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capstoneProject
{
    public partial class tasklistItem : UserControl
    {
        public tasklistItem()
        {
            InitializeComponent();
        }


        #region PROPERTIES

        private string _title;
        private string _description;

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lbl_taskTitle.Text = value; }
        }

        [Category("Custom Props")]
        public string Description
        {
            get { return _description; }
            set { _description = value; lbl_taskDescription.Text = value; }
        }

        #endregion


        private void Btn_deleteTask_Click(object sender, EventArgs e)
        {
            
        }

        private void Lbl_taskTitle_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_taskDescription_Click(object sender, EventArgs e)
        {

        }

        
    }
}
