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
    public partial class schedule : UserControl
    {
        public schedule()
        {
            InitializeComponent();
            goHideAll();
        }

        private void populateItems()
        {
            int taskCount = 0;
            tasklistItem[] listItems = new tasklistItem[0];

            listItems[taskCount + 1] = new tasklistItem();
        }

        private void Btn_addTask_Click(object sender, EventArgs e)
        {
            goHideAll();
            addTaskPrompt1.Show();
            addTaskPrompt1.BringToFront();
            btn_close_x.Show();
            btn_close_x.BringToFront();
        }

        private void goHideAll()
        {
            tasklistItem1.Hide();
            addTaskPrompt1.Hide();
            btn_close_x.Hide();
        }

        private void Btn_close_x_Click(object sender, EventArgs e)
        {
            goHideAll();
        }
    }
}
