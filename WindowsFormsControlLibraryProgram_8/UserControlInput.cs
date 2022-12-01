// Paxton Proctor
// 12/1/2022
// Contemporary Programming languages C#

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Policy;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace WindowsFormsControlLibraryProgram_8
{
    public partial class UserControlInput : UserControl
    {
        protected int TextBoxCount { get; set; } = 4; // number of TextBoxes

        // enumeration constants specify TextBox indices
        public enum TextBoxIndices { ID, Name, Price, Quantity }

        public UserControlInput()
        {
            InitializeComponent();
        }

        // set text box values to string-array values
        public void SetTextBoxValues(string[] values)
        {
            // determine whether string array has correct length
            if (values.Length != TextBoxCount)
            {
                // throw exception if not correct length
                throw (new ArgumentException(
                   $"There must be {TextBoxCount} strings in the array",
                   nameof(values)));
            }
            else // set array values if array has correct length
            {
                // set array values to TextBox values
                itemidtextBox.Text = values[(int)TextBoxIndices.ID];
                itemnametextBox.Text = values[(int)TextBoxIndices.Name];
                pricetextBox.Text = values[(int)TextBoxIndices.Price];
                quantitytextBox.Text = values[(int)TextBoxIndices.Quantity];
            }

        }

        // return TextBox values as string array
        public string[] GetTextBoxValues()
        {
            return new string[] {
                itemidtextBox.Text, itemnametextBox.Text,
                pricetextBox.Text, quantitytextBox.Text
            };
        }
    }
}
