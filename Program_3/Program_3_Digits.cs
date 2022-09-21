/// <summary>
/// Paxton Proctor
/// 9/6/2022
/// Write an app that inputs one number consisting of five digits from the user
/// , separates the number into its individual
/// digits and displays the digits separated from one another by three spaces
/// each. For example, if the user types in the
/// number 42339, the app should display 4 2 3 3 9
/// 
/// Result 1   2   3   4   5
/// 
/// The Results if you enter fewer than 5 digits is 0   0   1   2   3
/// 
/// The Results if you enter more than 5 digits is 2   3   4   5   6 and the index goes outside the array
/// </summary>

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_3_WinForms
{
    public partial class Program_3_Digits : Form
    {
        public Program_3_Digits()
        {
            InitializeComponent();

            // declaration
            digitBox1.KeyPress += DigitBox1_KeyPress;
            separateButton.Click += SeparateButton_Click;
        }

        // this button takes the integer from the textbox and separates the digits by 3 spaces
        #region Button Event
        private void SeparateButton_Click(object? sender, EventArgs e)
        {
            int[] digits = new int[5];

            int number = 0;

            number = int.Parse(digitBox1.Text);
            for(int i = 4; number > 0; i--)
            {
                int digit = number % 10;
                digits[i] = digit;
                number = number / 10;

                outputdisplayLabel.Text = "Output: " + digits[0] + "   " + digits[1] + "   " +
                    digits[2] + "   " + digits[3] + "   " + digits[4];
            }
        }
        #endregion

        // This textbox takes the users input and changes it into a integer.
        #region Textbox Event

        private void DigitBox1_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // allow only numbers and backspace
            if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}