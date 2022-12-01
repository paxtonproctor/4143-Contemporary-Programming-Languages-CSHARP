// Paxton Proctor
// 12/1/2022
// Contemporary Programming languages C#

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsControlLibraryProgram_8;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Program_8
{
    public partial class HardwareForm : Form
    {
        // passing the file string
        private string _file;
        private BinaryFormatter _formatter = new BinaryFormatter();
        private FileStream input; // maintains the connection to the file
        private StreamReader fileReader; // reads data from text file    

        public HardwareForm(string file)
        {
            InitializeComponent();

            _file = file;

            // calling list
            DisplayList();

        }

        /// <summary>
        /// display list is supposed to display the file onto the listbox
        /// </summary>
        private void DisplayList()
        {

            listBox1.Items.Clear();
            FileStream fstream = new FileStream(_file, FileMode.Open,
                FileAccess.Read);
            string output = " \t \t$ \t ";
            listBox1.Items.Add(String.Format(output, "ID", "Name", "Price", "Quantity"));
            try
            {
                while (true)
                {
                    RecordSerializable record = (RecordSerializable)_formatter.Deserialize(fstream);

                    output = record.ID + "\t" + record.Name + "\t$" + record.Price + "\t" +
                        record.Quantity + Environment.NewLine;

                    listBox1.Items.Add(output);
                }
            }
            catch (SerializationException)
            {

            }
            fstream.Close();
        }

        //Accepts a record to add to the .txt file
        public void AddItem(RecordSerializable r)
        {
            FileStream fstream = new FileStream(_file, FileMode.Append,
                FileAccess.Write);
            _formatter.Serialize(fstream, r);

            fstream.Close();

            DisplayList();
        }
    }
}
