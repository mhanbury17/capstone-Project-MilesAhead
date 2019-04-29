using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capstoneProject
{
    static class Program
    {
        //********************************************
        // Title: Miles Ahead
        // Application Type: winForm
        // Description: Track hours
        // Author: Miles Hanbury
        // Date Created: 4/21/2019
        // Last Modified: 4/28/2019
        //********************************************
        // Help Cited
        // Idea for how to write text file to list: https://stackoverflow.com/questions/6904401/how-best-to-read-a-file-into-liststring
        // Video where I learned how to use stream writer/reader: https://www.youtube.com/watch?v=Hd-RYDucqzw
        //********************************************

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new form_main());
        }
    }
}
