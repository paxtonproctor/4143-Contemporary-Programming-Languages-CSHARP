// Paxton Proctor
// 12/1/2022
// Contemporary Programming languages C#
/// </summary>
/// To create an MDI app that uses menus; list boxes (sorted); and a user control; to input and
/// output to serialized files; to use FileDialogs
/// <summary>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsControlLibraryProgram_8;

namespace Program_8
{
    public partial class FormMDI : Form
    {
        private StreamReader fileReader; //reads data from a textfile
        private StreamWriter fileWriter; //writes data to a text file

        private BinaryFormatter formatter = new BinaryFormatter();

        public FormMDI()
        {
            InitializeComponent();

            // clicks
            aboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            openToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            insertToolStripMenuItem1.Click += InsertToolStripMenuItem_Click;
        }

        #region Click Events

        /// <summary>
        /// Insert creates a form that has our user Control and passes data onto the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputForm info = new InputForm();
            info.ShowDialog();
            info.Close();
            RecordSerializable r = info.record;
            HardwareForm active = ActiveMdiChild as HardwareForm;
            if (r != null)
            {
                active.AddItem(r);
            }
        }

        /// <summary>
        /// Save allows the user to save what file they want which will override the files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create and show dialog box enbling user to save file
            DialogResult result; //result of the save file dialog
            String SaveFileName; //name of file that data is saved to

            using (SaveFileDialog SaveFile = new SaveFileDialog())
            {
                SaveFile.CheckFileExists = false; //allow user to create file
                result = SaveFile.ShowDialog(); //open the save file dialog
                SaveFileName = SaveFile.FileName;//Get the name of the file to save data
            }

            //Once the user clicks OK then save the data to th file
            if (result == DialogResult.OK)
            {
                //Show error if the user specified an invalid 
                if (SaveFileName == String.Empty)
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    //Save the file using Filestream one the user specified a valid file
                    try
                    {
                        //open file with write access
                        FileStream output = new FileStream(SaveFileName, FileMode.OpenOrCreate,
                            FileAccess.Write);

                        //set file to where data is written
                        fileWriter = new StreamWriter(output);

                        //Write sorted data to the file
                        //for (int i = 0; i < SortedFile.Length; i++)
                        //{
                        //    fileWriter.WriteLine(SortedFile[i]);
                        //}

                        fileWriter.Close(); //close the stream
                    }
                    catch (IOException)
                    {
                        //Notify user if file does not exists
                        MessageBox.Show("Error Saving Data to File.", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// allows the user to open and find the file they want. Must be a txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog filechooser = new OpenFileDialog();
            DialogResult result = filechooser.ShowDialog(); //Show open file dialog
            string filename;

            if (result != DialogResult.Cancel)
            {
                filename = filechooser.FileName; //get the name of the file selected
                if (!filename.Contains(".txt"))
                {
                    MessageBox.Show("This is not a .txt file");
                }
                else
                {
                    // create new child
                    HardwareForm workshop = new HardwareForm(filename);
                    // set parent
                    workshop.MdiParent = this;
                    // display child
                    workshop.Show();
                }
            }
        }

        /// <summary>
        /// exit application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// about just tells you where to go to do stuff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create new child
            AboutForm child = new AboutForm();
            // set parent
            child.MdiParent = this;
            // display child
            child.Show();
        }

        /// <summary>
        /// delete is suppose to delete an item from the data file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HardwareForm active = ActiveMdiChild as HardwareForm;
            //active.DeleteItem();
        }

        #endregion
    }
}
