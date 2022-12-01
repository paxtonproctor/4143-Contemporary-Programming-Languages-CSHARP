// Paxton Proctor
// 12/1/2022
// Contemporary Programming languages C#

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_8
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            closeButton.Click += CloseButton_Click;

            Aboutlabel.Text = "To Open the Files select file -> open -> select a .txt -> ok.\n" +
                "To Save File select file -> save -> save file.\n" +
                "To Exit go to file -> Exit\n" +
                "To add stuff to file go to edit -> insert -> type in values -> ok\n" +
                "To delete stuff in file go to edit -> delete -> click on entry to delete -> click ok\n";
        }

        /// <summary>
        /// close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
