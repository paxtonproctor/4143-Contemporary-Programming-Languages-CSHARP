// Paxton Proctor
// 12/1/2022
// Contemporary Programming languages C#

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsControlLibraryProgram_8;
using static WindowsFormsControlLibraryProgram_8.UserControlInput;

namespace Program_8
{
    public partial class InputForm : Form
    {
        public RecordSerializable record; 

        public InputForm()
        {
            InitializeComponent();

            okbutton.Click += Okbutton_Click;
        }

        private void Okbutton_Click(object sender, EventArgs e)
        {

            // store TextBox values string array
            string[] values = userControlInput1.GetTextBoxValues();

            // determine whether TextBox account field is empty
            if (!string.IsNullOrEmpty(values[(int)TextBoxIndices.ID]))
            {
                // store TextBox values in RecordSerializable and serialize it
                try
                {
                    // get account-number value from TextBox
                    int IDNumber = int.Parse(values[(int)TextBoxIndices.ID]);
                    // determine whether accountNumber is valid
                    if (IDNumber > 0)
                    {
                        // RecordSerializable to serialize
                        var record = new RecordSerializable(IDNumber,
                            values[(int)TextBoxIndices.Name],
                            double.Parse(values[(int)TextBoxIndices.Price]),
                            int.Parse(values[(int)TextBoxIndices.Quantity]));
                        // write Record to FileStream (serialize object)
                    }
                    else
                    {
                        // notify user if invalid account number
                        MessageBox.Show("Invalid Account Number", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SerializationException)
                {
                    MessageBox.Show("Error Writing to File", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Format", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
