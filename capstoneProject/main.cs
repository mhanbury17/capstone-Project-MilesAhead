using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capstoneProject
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
            goHideAll();
        }

        #region RECAP
        private void Lbl_Recap_Expenses_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Recap_Income_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        #endregion
        private void Lbl_accountName_Click(object sender, EventArgs e)
        {
            MessageBoxUpdates();
        }

        private void Btn_close_x_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Btn_moreStats_Click(object sender, EventArgs e)
        {
            MessageBoxUpdates();
        }

        private void Btn_menuWallet_Click(object sender, EventArgs e)
        {
            MessageBoxUpdates();
        }

        private void Btn_menuClockMng_Click(object sender, EventArgs e)
        {
            goHideAll();
            clockInformation1.Show();
            clockInformation1.BringToFront();
        }

        private void Btn_menuSchedule_Click(object sender, EventArgs e)
        {
            //goHideAll();
            //schedule1.Show();
            //schedule1.BringToFront();
            MessageBoxUpdates();
        }

        private void Btn_menuDash_Click(object sender, EventArgs e)
        {
            goHideAll();
        }

        private void Pbx_clock_Click(object sender, EventArgs e)
        {
            goHideAll();
            clockInformation1.Show();
            clockInformation1.BringToFront();

        }

        private void Pbx_schedule_Click(object sender, EventArgs e)
        {
            //goHideAll();
            //schedule1.Show();
            //schedule1.BringToFront();
            MessageBoxUpdates();
        }

        private void Pbx_money_Click(object sender, EventArgs e)
        {
            MessageBoxUpdates();
        }

        private void Pbx_settings_Click(object sender, EventArgs e)
        {
            MessageBoxUpdates();
        }
        private void goHideAll()
        {
            clockInformation1.Hide();
            schedule1.Hide();
        }

        private void MessageBoxUpdates()
        {
            MessageBox.Show("Feature not yet available. Will be added in the next update!");
        }

    }
}
